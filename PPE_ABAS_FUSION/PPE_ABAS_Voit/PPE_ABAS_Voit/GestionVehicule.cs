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
    public partial class GestionVehicule : Form
    {
        public string motif { get; set; }
        public GestionVehicule()
        {
            InitializeComponent();
        }

        private void GestionVehicule_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                IEnumerable<Voiture> voitures = connection.Query<Voiture>(SQLQueries.hotelGetVoitures, new { batId = Globals.selectedBat.bat_id });
                foreach (Voiture voit in voitures)
                {

                    string vehicule = voit.ToString();
                    string etat = "Indisponible";
                    string motif = voit.voit_motif;
                    if (voit.voit_disponible == true)
                    {
                        etat = "Disponible";
                    }


                    string[] arrayInter = new string[] {vehicule, etat, motif, voit.voit_id.ToString()};

                    //ajout des info dans la ListView
                    ListViewItem item;
                    item = new ListViewItem(arrayInter);
                    listView1.Items.Add(item);
                }
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int voit_id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            string dispo = listView1.SelectedItems[0].SubItems[1].Text.ToString();

            if ( dispo == "Disponible")
            {
                var saisieMotif = new SaisieMotif(this);
                saisieMotif.ShowDialog(this);
            }
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                if (dispo == "Disponible")
                {
                    string sqlString = SQLQueries.SetEtatIndisponible;
                    connection.Query(sqlString, new { voit_id = voit_id, motif = motif });
                    
                }
                else if (dispo == "Indisponible")
                {
                    string sqlString = SQLQueries.SetEtatDisponible;
                    connection.Query(sqlString, new { voit_id = voit_id });
                }
                MessageBox.Show("L'état du véhicule a bien été modifié ");
                listView1.Items.Clear();





                IEnumerable<Voiture> voitures = connection.Query<Voiture>(SQLQueries.hotelGetVoitures, new { batId = Globals.selectedBat.bat_id });
                foreach (Voiture voit in voitures)
                {

                    string vehicule = voit.ToString();
                    string etat = "Indisponible";
                    string motif = voit.voit_motif;
                    if (voit.voit_disponible == true)
                    {
                        etat = "Disponible";
                    }


                    string[] arrayInter = new string[] { vehicule, etat, motif, voit.voit_id.ToString() };

                    //ajout des info dans la ListView
                    ListViewItem item;
                    item = new ListViewItem(arrayInter);
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                contextMenuStrip1.Show(listView1, new Point(e.X, e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
