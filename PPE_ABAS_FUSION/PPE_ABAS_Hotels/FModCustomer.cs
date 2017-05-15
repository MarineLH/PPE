using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE_ABAS_Hotels.Properties;
using MySql.Data.MySqlClient;
using Dapper;

namespace PPE_ABAS_Hotels
{
    public partial class FModCustomer : Form
    {
        public Client _client { get; set; }

        public FModCustomer()
        {
            InitializeComponent();
        }

        public FModCustomer(Client client)
        {
            InitializeComponent();
            _client = client;
        }

        private void FModCustomer_Load(object sender, EventArgs e)
        {
            SetTexts();

            txt_CliNom.Text = _client.cli_nom;
            txt_CliPrenom.Text = _client.cli_prenom;
            txt_CliTel.Text = _client.cli_tel;
            txt_CliMail.Text = _client.cli_mail;
            txt_CliAdl1.Text = _client.cli_adl1;
            txt_CliAdl2.Text = _client.cli_adl2;
            txt_CliAdcp.Text = _client.cli_adcp;
            txt_CliAdville.Text = _client.cli_adville;
        }

        private void SetTexts()
        {
            Text = lbl_title.Text = Resources.f_mod_cust_title + _client.cli_id;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_validate_Click(object sender, EventArgs e)
        {
            _client.cli_nom = txt_CliNom.Text;
            _client.cli_prenom = txt_CliPrenom.Text;
            _client.cli_tel = txt_CliTel.Text.Replace(' ', '.');
            _client.cli_mail = txt_CliMail.Text;
            _client.cli_adl1 = txt_CliAdl1.Text;
            _client.cli_adl2 = txt_CliAdl2.Text;
            _client.cli_adcp = txt_CliAdcp.Text;
            _client.cli_adville = txt_CliAdville.Text;

            using (var connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                connection.Execute(SQLQueries.updateClient, _client);
            }

            MessageBox.Show(Resources.modif_success, Resources.success, MessageBoxButtons.OK);
            this.Dispose();
        }
    }
}
