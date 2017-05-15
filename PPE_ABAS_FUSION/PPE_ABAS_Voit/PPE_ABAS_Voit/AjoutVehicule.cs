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
    public partial class AjoutVehicule : Form
    {
        public AjoutVehicule()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string marque = textBox1.Text;
            string modele = textBox2.Text;
            string immatriculation = textBox3.Text;
            int kilometrage = Convert.ToInt32(textBox4.Text);
            int tarifUHT = Convert.ToInt32(textBox5.Text);
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                connection.Execute(SQLQueries.AddVehicule, new { marque = marque,  modele = modele, immat = immatriculation, km = kilometrage, tarifUHT = tarifUHT, tva = 1, batId = Globals.selectedBat.bat_id });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
