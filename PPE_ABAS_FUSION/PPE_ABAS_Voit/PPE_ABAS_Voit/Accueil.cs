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

namespace PPE_ABAS_Voit
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            IEnumerable<Batiment> batiments;

            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                batiments = connection.Query<Batiment>("select * from Batiment");
            }

            foreach (Batiment bat in batiments)
            {
                hotel_select.Items.Add(bat.bat_libelle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Batiment batiment;
            if (hotel_select.SelectedItem != null)
            {
                string selected = hotel_select.SelectedItem.ToString();
                using (MySqlConnection connexion = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string SQLQuery = SQLQueries.connexSelectUnBatiment;
                    batiment = connexion.Query<Batiment>(SQLQuery, new { libelle = selected }).FirstOrDefault();
                    Globals.selectedBat = batiment;
                }
                page_principale f_res = new page_principale();
                f_res.Show();
                this.Hide();

            }
        }
    }
}
