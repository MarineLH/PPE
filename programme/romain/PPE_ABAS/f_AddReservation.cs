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
using System.Text.RegularExpressions;

namespace PPE_ABAS
{
    public partial class f_AddReservation : Form
    {
        private Chambre SelectedChambre = null;
        private DateTime resDate, resDateSortie;

        public f_AddReservation()
        {
            InitializeComponent();
        }

        private void f_AddReservation_Load(object sender, EventArgs e)
        {
            dt_resDate.CustomFormat = "yyyy-MM-dd H:mm:ss";
            ChangeDateSortie();
            lbl_chambresDispos.Text = "";

            IEnumerable<Client> clients;
            IEnumerable<TypeChambre> typeChambres;

            // Connexion à la base puis requête et stockage des résultats
            // avantage c'est ouverture puis fermeture directe de la connexion
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                clients = connection.Query<Client>(SQLQueries.getClients);
            }

            // Ajout des noms des batiments dans la comboBox
            foreach (Client client in clients)
            {
                cb_existingClients.Items.Add(client);
            }

            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                typeChambres = connection.Query<TypeChambre>(SQLQueries.getTypesChambres);
            }
            foreach (TypeChambre typeChambre in typeChambres)
            {
                cb_typeChambre.Items.Add(typeChambre);
            }
        }

        private void cb_existingClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client selectedClient = (Client)cb_existingClients.SelectedItem;
            txt_CliNom.Text = selectedClient.cli_nom;
            txt_CliNom.Tag = selectedClient.cli_id;
            txt_CliPrenom.Text = selectedClient.cli_prenom;
            txt_CliTel.Text = selectedClient.cli_tel;
            txt_CliAdl1.Text = selectedClient.cli_adl1;
            txt_CliAdl2.Text = selectedClient.cli_adl2;
            txt_CliAdcp.Text = selectedClient.cli_adcp;
            txt_CliAdville.Text = selectedClient.cli_adville;
            txt_CliMail.Text = selectedClient.cli_mail;
        }

        private void rb_createClient_CheckedChanged(object sender, EventArgs e)
        {
            txt_CliNom.Text = "";
            txt_CliNom.Tag = null;
            txt_CliPrenom.Text = "";
            txt_CliTel.Text = "";
            txt_CliAdl1.Text = "";
            txt_CliAdl2.Text = "";
            txt_CliAdcp.Text = "";
            txt_CliAdville.Text = "";
            txt_CliMail.Text = "";

            txt_CliNom.Enabled = true;
            txt_CliPrenom.Enabled = true;
            txt_CliTel.Enabled = true;
            txt_CliAdl1.Enabled = true;
            txt_CliAdl2.Enabled = true;
            txt_CliAdcp.Enabled = true;
            txt_CliAdville.Enabled = true;
            txt_CliMail.Enabled = true;
            cb_existingClients.Enabled = false;
        }

        private void rb_searchClient_CheckedChanged(object sender, EventArgs e)
        {
            cb_existingClients.Enabled = true;
            txt_CliNom.Enabled = false;
            txt_CliPrenom.Enabled = false;
            txt_CliTel.Enabled = false;
            txt_CliAdl1.Enabled = false;
            txt_CliAdl2.Enabled = false;
            txt_CliAdcp.Enabled = false;
            txt_CliAdville.Enabled = false;
            txt_CliMail.Enabled = false;
        }

        private void dt_resDate_ValueChanged(object sender, EventArgs e)
        {
            ChangeDateSortie();
            SelectChambre();
        }

        private void nup_resNbJours_ValueChanged(object sender, EventArgs e)
        {
            ChangeDateSortie();
            SelectChambre();
        }

        private void cb_typeChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectChambre();
        }

        private void ChangeDateSortie()
        {
            resDate = new DateTime(dt_resDate.Value.Year, dt_resDate.Value.Month, dt_resDate.Value.Day);
            TimeSpan nbNuits = new TimeSpan((int)nup_resNbJours.Value, 12, 0, 0);

            resDateSortie = resDate + nbNuits;
            
            txt_resDateSortie.Text = resDateSortie.ToString("yyyy-MM-dd H:mm:ss");

        }

        private void SelectChambre()
        {
            int count;
            if (cb_typeChambre.SelectedItem != null)
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    dynamic result = connection.Query(
                        SQLQueries.countNbFreeChambres,
                        new
                        {
                            batId = Globals.selectedBat.bat_id,
                            typeId = ((TypeChambre)cb_typeChambre.SelectedItem).tc_id,
                            dateSortie = txt_resDateSortie.Text,
                            date = dt_resDate.Text
                        }
                    ).Single();
                    count = (int)result.Count;
                }
                if (count > 0)
                {
                    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {
                        SelectedChambre = connection.Query<Chambre>(
                            SQLQueries.selectFreeChambres,
                            new
                            {
                                batId = Globals.selectedBat.bat_id,
                                typeId = ((TypeChambre)cb_typeChambre.SelectedItem).tc_id,
                                dateSortie = txt_resDateSortie.Text,
                                date = dt_resDate.Text
                            }
                        ).First();
                    }
                    lbl_chambresDispos.Text = "Nombre de chambres disponibles : " + count.ToString() + " | Chambre sélectionnée : " + SelectedChambre.ToString();
                }
                else
                {
                    SelectedChambre = null;
                    lbl_chambresDispos.Text = "Aucune chambre de ce type disponible dans l'hôtel";
                }
            }
        }


        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_validate_Click(object sender, EventArgs e)
        {
            int clientId = 0;
            bool canContinueFromClient = false;

            // Utilisateur enregistré
            if (txt_CliNom.Text != "" && txt_CliNom.Tag != null)
            {
                canContinueFromClient = true;
                clientId = (int)txt_CliNom.Tag;
            }
            // Utilisateur à créer
            else if (txt_CliNom.Text != "" && txt_CliNom.Tag == null)
            {
                canContinueFromClient = true;

                Client newC = new Client
                {
                    cli_nom = txt_CliNom.Text,
                    cli_prenom = txt_CliPrenom.Text != "" ? txt_CliPrenom.Text : null,
                    cli_tel = txt_CliTel.Text != "            " ? txt_CliTel.Text.Replace(' ', '.') : null,
                    cli_mail = txt_CliMail.Text != "" ? txt_CliMail.Text : null,
                    cli_adl1 = txt_CliAdl1.Text != "" ? txt_CliAdl1.Text : null,
                    cli_adl2 = txt_CliAdl2.Text != "" ? txt_CliAdl2.Text : null,
                    cli_adcp = txt_CliAdcp.Text != "" ? txt_CliAdcp.Text : null,
                    cli_adville = txt_CliAdville.Text != "" ? txt_CliAdville.Text : null
                };
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    clientId = connection.Query<int>(SQLQueries.addClient, newC).Single();
                }
            }
            // Champ vide
            else if (txt_CliNom.Text == "")
            {
                canContinueFromClient = false;
            }

            if (canContinueFromClient)
            {
                // Pas de chambre sélectionnée.
                if(SelectedChambre != null)
                {
                    Reservation newResa = new Reservation
                    {
                        res_date = dt_resDate.Value,
                        res_nbJours = (int)nup_resNbJours.Value,
                        res_dateSortie = resDateSortie,
                        Client_cli_id = (int)clientId,
                        Chambre_Etage_Hotel_hotel_bat_id = SelectedChambre.Etage_Hotel_hotel_bat_id,
                        Chambre_Etage_etage_id = SelectedChambre.Etage_etage_id,
                        Chambre_ch_id = SelectedChambre.ch_id
                    };

                    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {
                        connection.Execute(SQLQueries.addResa, newResa);
                        MessageBox.Show("La réservation a bien été enregistrée !", "Succès", MessageBoxButtons.OK);
                        f_ReadReservations f = new f_ReadReservations();
                        f.MdiParent = this.MdiParent;
                        ((f_Main)this.MdiParent).ShowForm(f);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Aucune chambre n'a été sélectionnée !", "Attention", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas choisi ou créé de client !", "Attention", MessageBoxButtons.OK);
            }

        }
    }
}
