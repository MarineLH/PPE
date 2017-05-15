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
    public partial class page_principale : Form
    {
        private IEnumerable<Voiture> Voiture_Standard;
        private IEnumerable<Voiture> Voiture_Confort;
        private IEnumerable<Voiture> Voiture_Luxe;
        public page_principale()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Client leClient;
            IEnumerable<Reservation> reservations, resasAcVoit;

            // Connexion à la base puis requête et stockage des résultats
            // avantage c'est ouverture puis fermeture directe de la connexion
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                reservations = connection.Query<Reservation>(SQLQueries.hotelGetReservationsSansVoiture, new { batId = Globals.selectedBat.bat_id });
                resasAcVoit = connection.Query<Reservation>(SQLQueries.hotelGetReservationsAvecVoiture, new { batId = Globals.selectedBat.bat_id });

            }
            // Ajout des noms des batiments dans la comboBox
            foreach (Reservation reservation in reservations)
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string sqlString = SQLQueries.getClientById;
                    leClient = connection.Query<Client>(sqlString, new { cliId = reservation.Client_cli_id }).FirstOrDefault();
                }
                Select_Client.Items.Add(new ResClient(reservation, leClient));


            }
            foreach (Reservation reservation in resasAcVoit)
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string sqlString = SQLQueries.getClientById;
                    leClient = connection.Query<Client>(sqlString, new { cliId = reservation.Client_cli_id }).FirstOrDefault();
                    //laVoiture = connection.Query<Voiture>(SQLQueries.GetVoitureById, new { voitId = reservation.voiture_voit_id }).FirstOrDefault();
                }
                ResClient UneRes =new ResClient(reservation, leClient);
            }


                IEnumerable<Voiture> Voitures;

// Connexion à la base puis requête et stockage des résultats
// avantage c'est ouverture puis fermeture directe de la connexion
    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
    {
        Voitures = connection.Query<Voiture>(SQLQueries.hotelGetVoitures, new { batId = Globals.selectedBat.bat_id });
        Voiture_Standard = connection.Query<Voiture>(SQLQueries.SelectVoitureStandard, new { batId = Globals.selectedBat.bat_id });
        Voiture_Confort = connection.Query<Voiture>(SQLQueries.SelectVoitureConfort, new { batId = Globals.selectedBat.bat_id });
        Voiture_Luxe = connection.Query<Voiture>(SQLQueries.SelectVoitureLuxe, new { batId = Globals.selectedBat.bat_id });
    }
    Form f = new Accueil();
    f.Show();

    foreach (Reservation res in reservations)
    {
        if (res.Voiture_voit_id != 0)
        {
            Select_modele.Items.Remove(Voitures.Where(voiture => voiture.voit_id == res.Voiture_voit_id ));
        }
    }

}

private void Select_gamme_SelectedIndexChanged(object sender, EventArgs e)
{
    Select_modele.Enabled = true;
    Select_modele.Items.Clear();
    if ((string)Select_gamme.SelectedItem == "Standard")
    {
        foreach (Voiture voit in Voiture_Standard)
        {
            Select_modele.Items.Add(voit);

        }
    }
    if ((string)Select_gamme.SelectedItem == "Confort")
    {
        foreach (Voiture voit in Voiture_Confort)
        {
            Select_modele.Items.Add(voit);
        }
    }
    if ((string)Select_gamme.SelectedItem == "Luxe")
    {
        foreach (Voiture voit in Voiture_Luxe)
        {
            Select_modele.Items.Add(voit);
        }
    }
}

private void Select_Client_SelectedIndexChanged(object sender, EventArgs e)
{
    Select_gamme.Enabled = true;
}

private void Valider_Click(object sender, EventArgs e)
{
    int res_id = ((ResClient)Select_Client.SelectedItem).res.res_id;
    int voit_id = ((Voiture)Select_modele.SelectedItem).voit_id;
    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
{

    string sqlString = SQLQueries.hotelVoitureReserver;
    connection.Query(sqlString, new { res_id = res_id, Voit_id = voit_id });
    MessageBox.Show("La réservation du véhicule a bien été effectuée !");
}
}

private void button1_Click(object sender, EventArgs e)
{
AjoutVehicule f_voit = new AjoutVehicule();
f_voit.Show();

}

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_Client.Items.Clear();
            Select_modele.Items.Clear();
            listView1.Items.Clear();
            Select_Client.Text = "";
            Select_gamme.Text = "";
            Select_modele.Text = "";

                Client leClient;
                IEnumerable<Reservation> reservations, resasAcVoit;

                // Connexion à la base puis requête et stockage des résultats
                // avantage c'est ouverture puis fermeture directe de la connexion
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    reservations = connection.Query<Reservation>(SQLQueries.hotelGetReservationsSansVoiture, new { batId = Globals.selectedBat.bat_id });
                    resasAcVoit = connection.Query<Reservation>(SQLQueries.hotelGetReservationsAvecVoiture, new { batId = Globals.selectedBat.bat_id });

                }
                // Ajout des noms des batiments dans la comboBox
                foreach (Reservation reservation in reservations)
                {
                    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {
                        string sqlString = SQLQueries.getClientById;
                        leClient = connection.Query<Client>(sqlString, new { cliId = reservation.Client_cli_id }).FirstOrDefault();
                    }
                    Select_Client.Items.Add(new ResClient(reservation, leClient));


                }
                foreach (Reservation reservation in resasAcVoit)
                {
                    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {
                        string sqlString = SQLQueries.getClientById;
                        leClient = connection.Query<Client>(sqlString, new { cliId = reservation.Client_cli_id }).FirstOrDefault();
                        //laVoiture = connection.Query<Voiture>(SQLQueries.GetVoitureById, new { voitId = reservation.voiture_voit_id }).FirstOrDefault();
                    }
                    ResClient UneRes = new ResClient(reservation, leClient);
                }


                IEnumerable<Voiture> Voitures;

                // Connexion à la base puis requête et stockage des résultats
                // avantage c'est ouverture puis fermeture directe de la connexion
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    Voitures = connection.Query<Voiture>(SQLQueries.hotelGetVoitures, new { batId = Globals.selectedBat.bat_id });
                    Voiture_Standard = connection.Query<Voiture>(SQLQueries.SelectVoitureStandard, new { batId = Globals.selectedBat.bat_id });
                    Voiture_Confort = connection.Query<Voiture>(SQLQueries.SelectVoitureConfort, new { batId = Globals.selectedBat.bat_id });
                    Voiture_Luxe = connection.Query<Voiture>(SQLQueries.SelectVoitureLuxe, new { batId = Globals.selectedBat.bat_id });
                }
                foreach (Reservation res in reservations)
                {
                    if (res.Voiture_voit_id != 0)
                    {
                        Select_modele.Items.Remove(Voitures.Where(voiture => voiture.voit_id == res.Voiture_voit_id));
                    }
                }
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    IEnumerable<Reservation> resas = connection.Query<Reservation>(SQLQueries.hotelGetReservationsAvecVoiture, new { batId = Globals.selectedBat.bat_id });
                    IEnumerable<Voiture> voitures = connection.Query<Voiture>(SQLQueries.hotelGetVoitures, new { batId = Globals.selectedBat.bat_id });

                    foreach (Reservation res in resas)
                    {
                        Client cli = connection.Query<Client>(SQLQueries.getClientById, new { cliId = res.Client_cli_id }).FirstOrDefault();
                        Voiture voit = connection.Query<Voiture>(SQLQueries.getVoitureById, new { voitId = res.Voiture_voit_id }).FirstOrDefault();
                        string nomClient = cli.cli_prenom + " " + cli.cli_nom;
                        string dateFinRes = String.Format("{0:dd/MM/yyyy}", res.res_dateSortie);
                        string voiture = voit.voit_marque + " " + voit.voit_modele;


                        string[] arrayInter = new string[] { nomClient, voiture, dateFinRes, res.res_id.ToString() };

                        //ajout des info dans la ListView
                        ListViewItem item;
                        item = new ListViewItem(arrayInter);
                        listView1.Items.Add(item);
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionVehicule gerer = new GestionVehicule();
            gerer.Show();

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                contextMenuStrip1.Show(listView1, new Point(e.X, e.Y));
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int res_id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {

                string sqlString = SQLQueries.DelResVehicule;
                connection.Query(sqlString, new { res_id = res_id});
                MessageBox.Show("La réservation du véhicule a bien été supprimée ! => " + res_id.ToString());
            }
            listView1.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                IEnumerable<Reservation> resas = connection.Query<Reservation>(SQLQueries.hotelGetReservationsAvecVoiture, new { batId = Globals.selectedBat.bat_id });
                IEnumerable<Voiture> voitures = connection.Query<Voiture>(SQLQueries.hotelGetVoitures, new { batId = Globals.selectedBat.bat_id });

                foreach (Reservation res in resas)
                {
                    Client cli = connection.Query<Client>(SQLQueries.getClientById, new { cliId = res.Client_cli_id }).FirstOrDefault();
                    Voiture voit = connection.Query<Voiture>(SQLQueries.getVoitureById, new { voitId = res.Voiture_voit_id }).FirstOrDefault();
                    string nomClient = cli.cli_prenom + " " + cli.cli_nom;
                    string dateFinRes = String.Format("{0:dd/MM/yyyy}", res.res_dateSortie);
                    string voiture = voit.voit_marque + " " + voit.voit_modele;


                    string[] arrayInter = new string[] { nomClient, voiture, dateFinRes, res.res_id.ToString() };

                    //ajout des info dans la ListView
                    ListViewItem item;
                    item = new ListViewItem(arrayInter);
                    listView1.Items.Add(item);
                }
            }

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
