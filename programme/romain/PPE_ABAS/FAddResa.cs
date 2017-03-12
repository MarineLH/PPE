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

namespace PPE_ABAS
{
    public partial class FAddResa : Form
    {
        private Chambre _selectedChambre = null;
        private DateTime _resDate, _resDateSortie;
        private FMainMenu _parent;

        public FAddResa()
        {
            InitializeComponent();
        }

        public FAddResa(FMainMenu fParent)
        {
            InitializeComponent();
            _parent = fParent;
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void f_add_resa_Load(object sender, EventArgs e)
        {
            SetTexts();

            dt_resDate.CustomFormat = "yyyy-MM-dd H:mm:ss";
            dt_resDate.MinDate = DateTime.Today;
            ChangeDateSortie();
            lbl_chambresDispos.Text = "";

            IEnumerable<Client> clients;
            IEnumerable<TypeChambre> typeChambres;

            // Connexion à la base puis requête et stockage des résultats
            // avantage c'est ouverture puis fermeture directe de la connexion
            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                clients = connection.Query<Client>(SQLQueries.getClients);
            }
            // Ajout des noms des clients dans la comboBox
            foreach (var client in clients)
            {
                cb_existingClients.Items.Add(client);
            }

            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                typeChambres = connection.Query<TypeChambre>(SQLQueries.getTypesChambres);
            }
            foreach (var typeChambre in typeChambres)
            {
                cb_typeChambre.Items.Add(typeChambre);
            }
        }

        private void cb_existingClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClient = (Client) cb_existingClients.SelectedItem;
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
            txt_CliNom.Enabled = true;
            txt_CliNom.Tag = null; // vider le tag pour créer un nouveau client
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
            _resDate = new DateTime(dt_resDate.Value.Year, dt_resDate.Value.Month, dt_resDate.Value.Day);
            var nbNuits = new TimeSpan((int) nup_resNbJours.Value, 12, 0, 0);

            _resDateSortie = _resDate + nbNuits;

            txt_resDateSortie.Text = _resDateSortie.ToString("yyyy-MM-dd H:mm:ss");
        }

        private void SelectChambre()
        {
            int count;
            if (cb_typeChambre.SelectedItem == null) return;
            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                dynamic result = connection.Query(
                    SQLQueries.countNbFreeChambres,
                    new
                    {
                        batId = Globals.selectedBat.bat_id,
                        typeId = ((TypeChambre) cb_typeChambre.SelectedItem).tc_id,
                        dateSortie = txt_resDateSortie.Text,
                        date = dt_resDate.Text
                    }
                ).Single();
                count = (int) result.Count;
            }
            if (count > 0)
            {
                using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    _selectedChambre = connection.Query<Chambre>(
                        SQLQueries.selectFreeChambres,
                        new
                        {
                            batId = Globals.selectedBat.bat_id,
                            typeId = ((TypeChambre) cb_typeChambre.SelectedItem).tc_id,
                            dateSortie = txt_resDateSortie.Text,
                            date = dt_resDate.Text
                        }
                    ).First();
                }
                lbl_chambresDispos.Text = Resources.f_add_resas_chDispo + count + " | " +
                                          Resources.f_add_resas_chSelect + _selectedChambre;
            }
            else
            {
                _selectedChambre = null;
                lbl_chambresDispos.Text = Resources.f_add_resas_noDispo;
            }
        }


        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_validate_Click(object sender, EventArgs e)
        {
            var clientId = 0;
            var canContinueFromClient = false;

            // Utilisateur enregistré
            if (txt_CliNom.Text != "" && txt_CliNom.Tag != null)
            {
                canContinueFromClient = true;
                clientId = (int) txt_CliNom.Tag;
            }
            // Utilisateur à créer
            else if (txt_CliNom.Text != "" && txt_CliNom.Tag == null)
            {
                canContinueFromClient = true;

                var newC = new Client
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

            if (canContinueFromClient)
            {
                // Chambre sélectionnée.
                if (_selectedChambre != null)
                {
                    using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {
                        var client = connection.Query<Client>(SQLQueries.getClientById, new {cliId = clientId}).Single();

                        connection.Execute(SQLQueries.addResa, new
                        {
                            res_date = dt_resDate.Value,
                            res_nbJours = (int) nup_resNbJours.Value,
                            res_dateSortie = _resDateSortie,
                            Client_cli_id = client.cli_id,
                            Chambre_Etage_Hotel_hotel_bat_id = _selectedChambre.Etage_Hotel_hotel_bat_id,
                            Chambre_Etage_etage_id = _selectedChambre.Etage_etage_id,
                            Chambre_ch_id = _selectedChambre.ch_id
                        });

                        MessageBox.Show(Resources.f_add_resas_success, Resources.success, MessageBoxButtons.OK);
                        _parent.SetBatimentInfos();
                        Close();
                    }
                }
                // Pas de chambre sélectionnée.
                else
                {
                    MessageBox.Show(Resources.f_add_resas_no_ch, Resources.warning, MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(Resources.f_add_resas_no_client, Resources.warning, MessageBoxButtons.OK);
            }
        }

        private void SetTexts()
        {
            Text = Resources.f_add_resa_title;
            lbl_currentHotel.Text = Resources.f_add_resa_selected + Globals.selectedBat;
            bt_quit.Text = Resources.close;
        }
    }
}
