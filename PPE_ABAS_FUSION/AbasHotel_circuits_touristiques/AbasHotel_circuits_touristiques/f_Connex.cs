using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Dapper;


namespace PPE_ABAS_Circuits
{
    public partial class f_Connex : Form
    {
        /// <summary>
        /// renseignement des données pour la connexion à la base de données
        /// </summary>
        //public static string MySQLConnectionString = "Server=romainvaleye.ovh;Database=abas_db;Uid=abas_user;Pwd=3c51713e-534e-4a1d-bc8e-e51c29d3014e;";

        public static string nom_hotel;
        
        /// <summary>
        /// initialise les composants du form f_connex (pour la connexion à la BDD)
        /// </summary>
        public f_Connex()
        {
            InitializeComponent();
        }

        /// <summary>
        /// connexion à la base de données
        /// </summary>
        /// <param name="sender">objet qui soulève l'évènement</param>
        /// <param name="e">instance d'EventArgs incluant un objet qui hérite de EventArgs</param>
        public void f_connex_Load(object sender, EventArgs e)
        {
        
            IEnumerable<Batiment> batiments;

            // se connecte à la BDD en utilisant la requête de la classe "Globals"
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
               batiments = connection.Query<Batiment>("select * from Batiment");
            }

            // récupère les libellés des hôtels et ajoute cette liste à la comboBox
            foreach (Batiment bat in batiments)
            {
                cb_chooseBat.Items.Add(bat.bat_libelle);
                
            }
                        
            lb_no_selected_hotel.Visible = false;
           
        }

        /// <summary>
        /// cliquer pour valider le choix de l'hotel, affiche la fenêtre suivante : f_main
        /// </summary>
        /// <param name="sender">objet qui soulève l'évènement</param>
        /// <param name="e">instance d'EventArgs incluant un objet qui hérite de EventArgs</param>
        private void bt_val_choix_hotel_Click(object sender, EventArgs e)
        {
            Batiment bat_choisi;
            
            // vérifie si un hôtel est choisit
            if (cb_chooseBat.SelectedIndex > -1)
            {
                lb_no_selected_hotel.Visible = false;

                nom_hotel = cb_chooseBat.SelectedItem.ToString();

                // récupère les informations du batiment sélectionné
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string sql = "select * from Batiment where bat_libelle=@libelle";
                    bat_choisi = connection.Query<Batiment>(sql, new {libelle = nom_hotel}).FirstOrDefault();
                    Globals.selectedBat = bat_choisi;
                }

                f_main main = new f_main(bat_choisi);
                main.Show();
            }
            else
            {
                lb_no_selected_hotel.Visible = true;
            }        
        }
    }
}
