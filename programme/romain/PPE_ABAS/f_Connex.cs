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

namespace PPE_ABAS
{
    public partial class f_Connex : Form
    {
        public f_Connex()
        {
            InitializeComponent();
        }

        private void f_Connex_Load(object sender, EventArgs e)
        {
            IEnumerable<Batiment> batiments;

            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                batiments = connection.Query<Batiment>(SQLQueries.connexSelectBatiments);
            }

            foreach (Batiment bat in batiments)
            {
                cb_chooseBat.Items.Add(bat.bat_libelle);
            }
        }

        private void bt_selectBat_Click(object sender, EventArgs e)
        {
            Batiment SelectedBat;
            if (cb_chooseBat.SelectedItem != null)
            {
                string selected = cb_chooseBat.SelectedItem.ToString();
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string sqlgetbat = SQLQueries.connexSelectUnBatiment;

                    SelectedBat = connection.Query<Batiment>(sqlgetbat, new { libelle = selected }).FirstOrDefault();

                    Globals.selectedBat = SelectedBat;
                }
                

                this.MdiParent.Text = "INTERNE - " + Globals.selectedBat.bat_libelle;

                // Ouvrir un autre enfant MDI du main
                // Form deuxiemeEnfant = new Enfant();
                // deuxiemeEnfant.MdiParent = this.MdiParent;
                // deuxiemeEndant.Show();

                this.Close();
            }
        }
    }
}
