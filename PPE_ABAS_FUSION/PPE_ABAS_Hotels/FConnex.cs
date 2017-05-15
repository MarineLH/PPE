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
using PPE_ABAS_Hotels.Properties;

namespace PPE_ABAS_Hotels
{
    public partial class FConnex : Form
    {
        public FConnex()
        {
            InitializeComponent();
        }

        private void f_connex_Load(object sender, EventArgs e)
        {
            SetTexts();

            IEnumerable<Batiment> batiments;
            IEnumerable<Personnel> utilisateurs;

            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                batiments = connection.Query<Batiment>(SQLQueries.connexSelectBatiments);
                utilisateurs = connection.Query<Personnel>(SQLQueries.connexSelectUsers);
            }

            foreach (Batiment bat in batiments)
            {
                cb_chooseBat.Items.Add(bat);
            }
            foreach (Personnel user in utilisateurs)
            {
                cb_chooseUser.Items.Add(user);
            }
        }

        private void bt_connex_Click(object sender, EventArgs e)
        {
            bool continuer = true;
            string message = Resources.error_occured;
            if (null == cb_chooseBat.SelectedItem && null == cb_chooseUser.SelectedItem)
            {
                continuer = false;
                message = Resources.f_connex_no_both;
            }
            else if (null == cb_chooseBat.SelectedItem && null != cb_chooseUser.SelectedItem)
            {
                continuer = false;
                message = Resources.f_connex_no_bat;
            }
            else if (null != cb_chooseBat.SelectedItem && null == cb_chooseUser.SelectedItem)
            {
                continuer = false;
                message = Resources.f_connex_no_pers;
            }

            if (!continuer)
            {
                MessageBox.Show(message, Resources.warning, MessageBoxButtons.OK);
                return;
            }

            Globals.selectedBat = (Batiment) cb_chooseBat.SelectedItem;
            Globals.selectedUser = (Personnel) cb_chooseUser.SelectedItem;

            // Cache le formulaire de connexion
            this.Hide();
            Form fMain = new FMainMenu();
            // Ferme le formulaire de connexion caché quand à l'événement de fermeture du formulaire principal.
            fMain.FormClosed += (s, args) => this.Close();
            fMain.Show();
        }

        private void SetTexts()
        {
            this.Text = groupBox1.Text = Resources.f_connex_title;
            lbl_chooseBat.Text = Resources.f_connex_select_bat;
            lbl_chooseUser.Text = Resources.f_connex_select_user;
            bt_connex.Text = Resources.val;
        }

        private void cb_chooseBat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_chooseUser.Items.Clear();
            cb_chooseUser.Text = "";

            IEnumerable<Personnel> utilisateurs;

            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                utilisateurs = connection.Query<Personnel>(SQLQueries.connexSelectUsersByBat,
                    new {batId = ((Batiment) cb_chooseBat.SelectedItem).bat_id});
            }

            foreach (Personnel personnel in utilisateurs)
            {
                cb_chooseUser.Items.Add(personnel);
            }
        }
    }
}