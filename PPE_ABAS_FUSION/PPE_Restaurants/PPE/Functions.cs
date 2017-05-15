using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace PPE_ABAS_RES
{
    public static class Functions
    {
        private static readonly MySqlConnection Connection = new MySqlConnection(Globals.ConnectionString);

        #region Form 1 Functions

        /// <summary>
        /// Fonction de récupération des bâtiments dans la db et return dans une liste 
        /// </summary>
        /// <returns>Liste de bâtiments en IEnumerable</returns>
        public static IEnumerable<Batiment> GetBatiments()
        {
            using (Connection)
            {
                return Connection.Query<Batiment>(SQLQueries.restaurantGetBatiments);
            }
        }

        /// <summary>
        /// Récupère le bâtiment correspondant au libelle dans la combobox de départ + stockage dans le Globals
        /// </summary>
        /// <param name="comboBat">Combobox où l'on récupère le nom du bâtiment</param>
        public static void SelectGlobalBatByName(ComboBox comboBat)
        {
            using (Connection)
            {
                Globals.GlobalBat =
                    Connection.Query<Batiment>(SQLQueries.getBat, new {libelle = comboBat.SelectedItem.ToString()})
                        .FirstOrDefault();
            }
        }

        #endregion

        #region authenticationForm Functions

        /// <summary>
        /// Récupération de la liste du personnel correspondant à l'id de batiment et return en IEnumerable
        /// </summary>
        /// <returns>liste du personnel du batiment en IEnumerable</returns>
        public static IEnumerable<Personnel> GetPersonnels()
        {
            using (Connection)
            {
                return Connection.Query<Personnel>(SQLQueries.getPersonnel, new {batId = Globals.GlobalBat.bat_id});
            }
        }

        /// <summary>
        /// Récupère l'utilisateur en fonction d'un id et le stock dans les Globals
        /// </summary>
        /// <param name="selectedUserId">Id de l'utilisateur en int</param>
        public static void SelectUser(int selectedUserId)
        {
            using (Connection)
            {
                Globals.GlobalUser =
                    Connection.Query<Personnel>(SQLQueries.getPersonnelById, new {persId = selectedUserId})
                        .FirstOrDefault();
            }
        }

        #endregion

        #region mainForm

        // REMPLIR LA LISTE DE TABLE DE LA DB (exécuté une seule fois, trop long à la main) 
        private static void FillTableListDb()
        {
            using (Connection)
            {
                for (var i = 1; i < 11; i++)
                {
                    for (var j = 1; j < 21; j++)
                    {
                        Connection.Query(SQLQueries.insertTablesSoBoringDude, new {idResto = i, idTAB = j});
                    }
                }
            }
        }

        /// <summary>
        ///  Récupération de l'id de la table MAX du restaurant ( = nombre de tables total) 
        /// </summary>
        /// <returns>ID max de table du restaurant en INT</returns>
        public static int GetMaxTable()
        {
            using (Connection)
            {
                return
                    Connection.Query<int>(SQLQueries.restaurantGetMaxTableBatiment,
                        new {batId = Globals.GlobalBat.bat_id}).FirstOrDefault();
            }
        }

        /// <summary>
        /// Récupération du nombre de tables réservées en fonction de la date
        /// </summary>
        /// <param name="completeDate">date en string</param>
        /// <returns>le nombre de tables réservées en int</returns>
        public static int GetTakenTable(string completeDate)
        {
            using (Connection)
            {
                return
                    Connection.Query<int>(SQLQueries.restaurantGetNombreTablesReservees,
                            new {batId = Globals.GlobalBat.bat_id, date = completeDate})
                        .FirstOrDefault();
            }
        }

        /// <summary>
        /// Récupération de la liste de réservations pour un restaurant donné 
        /// </summary>
        /// <returns>Retourne les réservations, le nombre de tables par client (group by client / date)</returns>
        public static IEnumerable<reserverRestaurant> GetWaitingReservations()
        {
            using (Connection)
            {
                //Requête qui récupère les différentes réservations et compte le nombre de tables par client
                return Connection.Query<reserverRestaurant>(SQLQueries.restaurantSelectWaitingReservations,
                    new {batId = Globals.GlobalBat.bat_id});
            }
        }

        public static IEnumerable<reserverRestaurant> GetValidCancelReservations()
        {
            using (Connection)
            {
                //Requête qui récupère les différentes réservations et compte le nombre de tables par client
                return Connection.Query<reserverRestaurant>(SQLQueries.restaurantSelectValidCancelReservations,
                    new {batId = Globals.GlobalBat.bat_id});
            }
        }

        //Récupération de l'état de la réservation (label à partir de l'id )
        public static string getReservStatusLabel(int idStatus)
        {
            using (Connection)
            {
                return Connection.Query<string>(SQLQueries.getReservationStatusLabel,
                        new {IDRESERVSTATUS = idStatus})
                    .FirstOrDefault();
            }
        }

        public static IEnumerable<reserverRestaurant> GetPastReservations()
        {
            //Connexion à la base puis requête et stockage des résultats
            //avantage c'est ouverture puis fermeture directe de la connexion
            using (Connection)
            {
                return Connection.Query<reserverRestaurant>(SQLQueries.restaurantSelectPastReservations,
                    new {batId = Globals.GlobalBat.bat_id});
            }
        }

        public static Client GetClientById(int idClient)
        {
            using (Connection)
            {
                return
                    Connection.Query<Client>(SQLQueries.restaurantSelectClientWithId, new {id = idClient})
                        .FirstOrDefault();
            }
        }

        public static int GetClientIdByName(string nameClient)
        {
            using (Connection)
            {
                return
                    Connection.Query<int>(SQLQueries.restaurantFindClientIdByName, new {nomClient = nameClient})
                        .FirstOrDefault();
            }
        }

        public static void InsertClientDb(string clientName, string clientTel)
        {
            using (Connection)
            {
                //D'abord, on insère le client dans la DB
                Connection.Query(SQLQueries.restaurantInsertClient,
                    new {nomClient = clientName, telClient = clientTel});
            }
        }

        public static void updateStatusReservation(string resDH, string pIdClient, int stateID)
        {
            using (Connection)
            {
                Connection.Query(SQLQueries.updateStatusReservation,
                    new
                    {
                        STATEID = stateID,
                        DATETIME = DateTime.Parse(resDH).ToString("yyyy-MM-dd HH:mm:ss"),
                        CLIID = int.Parse(pIdClient)
                    });
            }
        }

        public static void fillListView(ListView listv, IEnumerable<reserverRestaurant> reservations)
        {
            foreach (var reservation in reservations)
            {
                var dateRes = listv.Items.Add(reservation.res_dh.ToString());

                dateRes.SubItems.Add(Functions.GetClientById(reservation.Client_cli_id).cli_nom);

                dateRes.SubItems.Add(reservation.nbtables.ToString());

                dateRes.SubItems.Add(Functions.getReservStatusLabel(reservation.status_id));

                dateRes.Tag = reservation.Client_cli_id;

                switch (reservation.status_id)
                {
                    case 1:
                        dateRes.BackColor = Color.FromArgb(240, 198, 0);
                        break;
                    case 2:
                        dateRes.BackColor = Color.FromArgb(24, 205, 108);
                        break;
                    case 3:
                        dateRes.BackColor = Color.FromArgb(190, 195, 199);
                        break;
                    case 4:
                        dateRes.BackColor = Color.FromArgb(235, 76, 55);
                        break;
                    case 5:
                        dateRes.BackColor = Color.FromArgb(46, 150, 223);
                        break;
                }
            }
        }

        public static void launchUpdateReservationStatus(int currentStatusId, int newStatusId)
        {
            using (Connection)
            {
                Connection.Query(SQLQueries.launchUpdateStatusReservation,
                    new {CURRENTID = currentStatusId, STATEID = newStatusId});
            }
        }

        public static void storeGlobalReservation(string cliId, string resDateTime)
        {
            using (Connection)
            {
                Globals.TempModifyReserverRestaurant =
                    Connection.Query<reserverRestaurant>(SQLQueries.getReservationsByClientDate,
                        new
                        {
                            clidID = int.Parse(cliId),
                            DATEHEURE = DateTime.Parse(resDateTime).ToString("yyyy-MM-dd HH:mm:ss")
                        });
            }
        }

        public static int GetFreeTables(DateTimePicker dtp1, Label labelNbTables, NumericUpDown tablesUD)
        {
            //Récupération du nombre de tables déjà réservées 
            var yearDtp = DateTime.Parse(dtp1.Value.ToString()).Year;

            var monthDtp = DateTime.Parse(dtp1.Value.ToString()).Month;

            var dayDtp = DateTime.Parse(dtp1.Value.ToString()).Day;

            var dateComplete = (new DateTime(yearDtp, monthDtp, dayDtp)).ToString("yyyy-MM-dd") + "%";


            var nombreDeTablesLibres = Functions.GetMaxTable() - Functions.GetTakenTable(dateComplete);

            //On met à jour le text du label 
            if (nombreDeTablesLibres != 0)
            {
                labelNbTables.Text = Strings.availableTables + nombreDeTablesLibres;

                tablesUD.Maximum = nombreDeTablesLibres;

                tablesUD.Visible = true;
            }
            else
            {
                var dateDtp = (new DateTime(yearDtp, monthDtp, dayDtp)).ToString("yyyy-MM-dd");
                if (dateDtp == (DateTime.Now).ToString("yyyy-MM-dd"))
                {
                    labelNbTables.Text = Strings.fullTtoday;
                }
                else
                {
                    labelNbTables.Text = Strings.fullThatDay;
                }


                tablesUD.Visible = false;
            }

            return nombreDeTablesLibres;
        }

        public static int getMaxIdValidReservation(DateTimePicker dtp1, string nameTB)
        {
            var yearDTP = DateTime.Parse(dtp1.Value.ToString()).Year;
            var monthDTP = DateTime.Parse(dtp1.Value.ToString()).Month;
            var dayDTP = DateTime.Parse(dtp1.Value.ToString()).Day;

            var startDate = (new DateTime(yearDTP, monthDTP, dayDTP, 0, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss");
            var endDate = (new DateTime(yearDTP, monthDTP, dayDTP, 23, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss");

            using (Connection)
            {
                var idMaxTable = Connection.Query<int>(SQLQueries.getNBValidReservation,
                        new {STARTDT = startDate, ENDDT = endDate, CLIID = Functions.GetClientIdByName(nameTB)})
                    .FirstOrDefault();
                if (String.IsNullOrEmpty(idMaxTable.ToString()))
                {
                    return idMaxTable;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static void CreateReservation(DateTimePicker dtp1, string nameTB, string telTB, string hourUD,
            string minUD, NumericUpDown tablesUD, Label labelNbTables)
        {
            //récupération du nombre de table libres
            var nombreDeTablesLibres = GetFreeTables(dtp1, labelNbTables, tablesUD);

            //On insère le client
            Functions.InsertClientDb(nameTB, telTB);

            //Puis on créé sa réservation 

            var yearDTP = DateTime.Parse(dtp1.Value.ToString()).Year;
            var monthDTP = DateTime.Parse(dtp1.Value.ToString()).Month;
            var dayDTP = DateTime.Parse(dtp1.Value.ToString()).Day;

            var dateComplete = (new DateTime(yearDTP, monthDTP, dayDTP)).ToString("yyyy-MM-dd") + " " +
                               hourUD + ":" + minUD + ":00";


            //début des requêtes SQL
            using (var connection = new MySqlConnection(Globals.ConnectionString))
            {
                for (var i = nombreDeTablesLibres; i > nombreDeTablesLibres - Convert.ToInt32(tablesUD.Value); i--)
                {
                    connection.Query(SQLQueries.restaurantReserverTable,
                        new
                        {
                            idCLIENT = Functions.GetClientIdByName(nameTB),
                            DATEHEURE = dateComplete,
                            idTABLE = i,
                            idRESTAU = Globals.GlobalBat.bat_id
                        });
                }
            }
        }

        public static int getNbAllReservations()
        {
            using (Connection)
            {
                return Connection.Query<int>(SQLQueries.getNbAllReservations).FirstOrDefault();
            }
        }

        public static int getNbgetNbReservationsByStatus(int idStatus)
        {
            using (Connection)
            {
                return Connection.Query<int>(SQLQueries.getNbReservationsByStatus,
                    new {IDSTATUS = idStatus, BATID = Globals.GlobalBat.bat_id}).FirstOrDefault();
            }
        }
    }

    #endregion
}

