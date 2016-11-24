using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Dapper;
using MySql.Data.MySqlClient;
using BrightIdeasSoftware;

namespace PPE_ABAS
{
    public partial class f_ReadReservations : Form
    {
        public f_ReadReservations(int TabIndex = 0)
        {
            InitializeComponent();
            tab_ReservationsLists.SelectedIndex = TabIndex;
        }

        private void f_ReadReservations_Load(object sender, EventArgs e)
        {
            
            Init_ListView(lv_resa_EnCours);
            Init_ListView(lv_resa_Histo);

            Fill_ListView(lv_resa_EnCours, SQLQueries.hotelGetReservations);
            Fill_ListView(lv_resa_Histo, SQLQueries.hotelGetHistorique);
            

            
        }

        private void Init_ListView(ListView lv)
        {
            // Declare and construct the ColumnHeader objects.
            ColumnHeader dateHeader, nameHeader, nbJoursHeader, numChambre;
            dateHeader = new ColumnHeader();
            nameHeader = new ColumnHeader();
            nbJoursHeader = new ColumnHeader();
            numChambre = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            dateHeader.Text = "Date";
            dateHeader.TextAlign = HorizontalAlignment.Left;
            dateHeader.Width = 150;

            nameHeader.TextAlign = HorizontalAlignment.Left;
            nameHeader.Text = "Nom";
            nameHeader.Width = 200;

            nbJoursHeader.TextAlign = HorizontalAlignment.Left;
            nbJoursHeader.Text = "Nombre de nuits";
            nbJoursHeader.Width = 130;

            numChambre.TextAlign = HorizontalAlignment.Left;
            numChambre.Text = "Numéro Chambre";
            numChambre.Width = 130;
            
            // Add the headers to the ListView control.
            lv.Columns.Add(dateHeader);
            lv.Columns.Add(nameHeader);
            lv.Columns.Add(nbJoursHeader);
            lv.Columns.Add(numChambre);
        }

        private void Fill_ListView(ListView lv, string SQLQuery)
        {
            Client leClient;
            IEnumerable<Reservation> reservations;

            // Connexion à la base puis requête et stockage des résultats
            // avantage c'est ouverture puis fermeture directe de la connexion
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                reservations = connection.Query<Reservation>(SQLQuery, new { batId = Globals.selectedBat.bat_id });
            }

            // Ajout des noms des batiments dans la comboBox
            foreach (Reservation reservation in reservations)
            {

                ListViewItem lv_item = new ListViewItem();

                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string sqlString = SQLQueries.getClientById;

                    leClient = connection.Query<Client>(sqlString, new { cliId = reservation.Client_cli_id }).FirstOrDefault();
                }

                lv_item.Tag = reservation.res_id;
                lv_item.SubItems[0].Text = reservation.res_date.ToString();
                lv_item.SubItems.Add(leClient.cli_nom);
                lv_item.SubItems.Add(reservation.res_nbJours.ToString());
                lv_item.SubItems.Add(reservation.NoChambre());

                lv.Items.Add(lv_item);

            }
        }
    }
}
