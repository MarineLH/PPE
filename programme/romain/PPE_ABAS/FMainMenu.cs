using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using PPE_ABAS.Properties;
using System.Diagnostics;

namespace PPE_ABAS
{
    public partial class FMainMenu : Form
    {
        public IEnumerable<Reservation> HotelResasEnCours, HotelHistorique;
        public IEnumerable<Client> HotelClients;
         
        public FMainMenu()
        {
            InitializeComponent();
        }

        private void f_main_menu_Load(object sender, EventArgs e)
        {
            // Remplit la combobox pour changer rapidement de bâtiment
            IEnumerable<Batiment> batiments;
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                batiments = connection.Query<Batiment>(SQLQueries.connexSelectBatiments);
            }

            foreach (Batiment bat in batiments)
            {
                cb_chooseBat.Items.Add(bat);
            }
            cb_chooseBat.Items.Insert(0, Resources.f_main_quick_select_bat);
            cb_chooseBat.SelectedIndex = 0;

            SetTexts();

            SetBatimentInfos();
        }

        private void cb_chooseBat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_chooseBat.SelectedIndex == 0) return;
            Globals.selectedBat = (Batiment)cb_chooseBat.SelectedItem;

            FQuickSwitch quickSwitch = new FQuickSwitch();
            quickSwitch.ShowDialog(this);

            SetBatimentInfos();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetBatimentInfos()
        {

            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                var queryResa = SQLQueries.hotelGetReservations;
                var queryHisto = SQLQueries.hotelGetHistorique;
                var queryClients = SQLQueries.getClientsByHotel;

                // update resas en cours
                this.HotelResasEnCours = connection.Query<Reservation, Client, ReservationStatus, Reservation>(
                    queryResa, 
                    (laResa, sonClient, sonStatut) => {
                        laResa.Client_cli_id = sonClient;
                        laResa.ReservationStatus_rest_id = sonStatut;
                        return laResa;
                    }, 
                    new { batId = Globals.selectedBat.bat_id }, 
                    splitOn: "Client_cli_id, reservStatus_id");

                // update historique
                this.HotelHistorique = connection.Query<Reservation, Client, ReservationStatus, Reservation>(
                    queryHisto,
                    (laResa, sonClient, sonStatut) =>
                    {
                        laResa.Client_cli_id = sonClient;
                        laResa.ReservationStatus_rest_id = sonStatut;
                        return laResa;
                    }, 
                    new { batId = Globals.selectedBat.bat_id }, 
                    splitOn: "Client_cli_id, reservStatus_id");

                /* ANCIENNE METHODE
                histo = connection.Query<Reservation>(queryHisto, new { batId = Globals.selectedBat.bat_id });
                foreach (Reservation reservation in histo)
                {
                    leClient = connection.Query<Client>(SQLQueries.getClientById, new { cliId = reservation.Client_cli_id }).Single();
                    this.HotelHistorique.Add(new ResClient(reservation, leClient));
                }
                */
                // update clients de l'hotel
                this.HotelClients = connection.Query<Client>(queryClients, new { batId = Globals.selectedBat.bat_id });
            }

            UpdateOlVs();
            SetTexts();
        }

        private void UpdateOlVs()
        {
            olv_resas.ClearObjects();
            olv_resas.SetObjects(this.HotelResasEnCours);

            olv_histo.ClearObjects();
            olv_histo.SetObjects(this.HotelHistorique);

            olv_clients.ClearObjects();
            olv_clients.SetObjects(this.HotelClients);
        }

        private void bt_addRes_Click(object sender, EventArgs e)
        {
            Form fAddResa = new FAddResa(this);
            fAddResa.ShowDialog(this);
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resa = getSelectedReservation(sender);
            if (resa == null)
            {
                return;
            }
            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                connection.Execute(SQLQueries.setResaStatut, new { statut = 2, resId = resa.res_id});
            }
            SetBatimentInfos();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resa = getSelectedReservation(sender);
            if (resa == null)
            {
                return;
            }
            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                connection.Execute(SQLQueries.setResaStatut, new { statut = 3, resId = resa.res_id });
            }
            SetBatimentInfos();
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resa = getSelectedReservation(sender);
            if (resa == null)
            {
                return;
            }
            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                connection.Execute(SQLQueries.setResaStatut, new { statut = 4, resId = resa.res_id });
            }
            SetBatimentInfos();
        }

        private static Reservation getSelectedReservation(object sender)
        {
            Reservation resa;
            try
            {
                resa =
                    (Reservation)
                    ((BrightIdeasSoftware.ObjectListView)
                        ((ContextMenuStrip) ((ToolStripItem) sender).GetCurrentParent()).SourceControl).SelectedItem
                    .RowObject;
            }
            catch (Exception exception)
            {
                resa = null;
            }
            return resa;
        }

        private void olv_resas_MouseClick(object sender, MouseEventArgs e)
        {
            bool match = false;

            if (e.Button == MouseButtons.Right)
            {
                if (olv_resas.FocusedItem.Bounds.Contains(e.Location))
                {
                    cm_olvi.Show(olv_resas, new Point(e.X, e.Y));
                }
            }
        }

        private void olv_clients_MouseClick(object sender, MouseEventArgs e)
        {
            bool match = false;

            if (e.Button == MouseButtons.Right)
            {
                if (olv_clients.FocusedItem.Bounds.Contains(e.Location))
                {
                    cm_olvi_client.Show(olv_clients, new Point(e.X, e.Y));
                }
            }
        }

        private void modifierLesInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client;
            try
            {
                client =
                    (Client)
                    ((BrightIdeasSoftware.ObjectListView)
                        ((ContextMenuStrip)((ToolStripItem)sender).GetCurrentParent()).SourceControl).SelectedItem
                    .RowObject;
            }
            catch (Exception exception)
            {
                client = null;
            }

            if (client != null)
            {
                var FMod = new FModCustomer(client);
                FMod.ShowDialog(this);
                SetBatimentInfos();
            }
        }

        private void SetTexts()
        {
            // Mise en place des strings
            this.Text = Resources.f_main_menu_title;
            tp_resas_en_cours.Text = Resources.tp_resas_en_cours;
            tp_historique.Text = Resources.tp_historique;
            tp_clientsHotel.Text = Resources.tp_clientsHotel;
            bt_quit.Text = Resources.quit;
            bt_addRes.Text = Resources.f_main_add;

            lbl_selectedBat.Text = Globals.selectedBat.ToString();
            lbl_user.Text = Globals.selectedUser.ToString();
            
            // OLVC resas
            olvc_resa_clientName.Text = Resources.olvc_clientName;
            olvc_resa_date.Text = Resources.olvc_date;
            olvc_resa_nbJours.Text = Resources.olvc_nbJours;
            olvc_resa_dateSortie.Text = Resources.olvc_dateSortie;
            olvc_resa_numChambre.Text = Resources.olvc_numChambre;
            olvc_resa_status.Text = Resources.olvc_status;

            // OLVC Histo
            olvc_histo_client.Text = Resources.olvc_clientName;
            olvc_histo_date.Text = Resources.olvc_date;
            olvc_histo_nbJours.Text = Resources.olvc_nbJours;
            olvc_histo_dateSortie.Text = Resources.olvc_dateSortie;
            olvc_histo_chambre.Text = Resources.olvc_numChambre;
            olvc_histo_status.Text = Resources.olvc_status;

            // OLVC client
            olvc_client_clientName.Text = Resources.olvc_clientName;
            olvc_client_adl1.Text = Resources.olvc_adl1;
            olvc_client_adcp.Text = Resources.olvc_adcp;
            olvc_client_adville.Text = Resources.olvc_adville;
            olvc_client_tel.Text = Resources.olvc_tel;
            olvc_client_mail.Text = Resources.olvc_mail;
            olvc_client_totalHotel.Text = Resources.olvc_totalHotel;
            olvc_client_totalChaine.Text = Resources.olvc_totalChaine;
        }
    }
}
