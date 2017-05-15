using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ABAS_RES
{
    public static class SQLQueries
    {
        /// <summary>
        /// Récupération d'un bâtiment en fonction libelle en paramètre
        /// </summary>
        public static string getBat = "SELECT * FROM Batiment WHERE bat_libelle = @libelle";

        /// <summary>
        /// Récupération de la liste de personne en fonction de l'id du bâtiment en paramètre
        /// </summary>
        public static string getPersonnel = "SELECT * FROM Personnel WHERE Batiment_bat_id = @batId";

        /// <summary>
        /// Récupération d'un user en fonction de son id en paramètre
        /// </summary>
        public static string getPersonnelById = "SELECT * FROM Personnel WHERE pers_id  = @persId";

        /// <summary>
        /// Récupération d'un client du restaurant avec son cli_id en paramètre
        /// </summary>
        public static string restaurantSelectClientWithId = "SELECT * FROM Client WHERE cli_id = @id;";

        /// <summary>
        /// Récupère les bâtiments ordonnés par le nom
        /// </summary>
        public static string restaurantGetBatiments = "SELECT * FROM Batiment ORDER BY bat_libelle";


        /// <summary>
        /// Récupère la liste des réservations pour un client :
        /// Le nombre de tables pour le client pour une date et heure donnée
        /// En fonction du bâtiment sélectionné  et la date et l'heure d'aujourd'hui
        /// </summary>
        public static string restaurantSelectWaitingReservations =
            @"SELECT *, COUNT(*) AS nbtables FROM reserverRestaurant 
                                                              WHERE res_dh >= DATE(NOW()) AND (status_id = 1) AND Table_Restaurant_resto_bat_id = @batId 
                                                              GROUP BY Client_cli_id, res_dh 
                                                              ORDER BY res_dh;";

        public static string restaurantSelectValidCancelReservations =
            @"SELECT *, COUNT(*) AS nbtables FROM reserverRestaurant 
                                                              WHERE res_dh >= DATE(NOW()) AND (status_id = 2 OR status_id = 4 or status_id = 5) AND Table_Restaurant_resto_bat_id = @batId 
                                                              GROUP BY Client_cli_id, status_id, res_dh 
                                                              ORDER BY res_dh;";


        /// <summary>
        /// Récupère la liste des réservations PASSEES pour un client :
        /// Le nombre de tables pour le client pour une date et heure donnée
        /// En fonction du bâtiment sélectionné  et la date et l'heure d'aujourd'hui
        /// </summary>
        public static string restaurantSelectPastReservations = @"SELECT*, COUNT(*) AS nbtables FROM reserverRestaurant 
                                                              WHERE res_dh < DATE(NOW()) AND Table_Restaurant_resto_bat_id = @batId 
                                                              GROUP BY Client_cli_id, res_dh 
                                                              ORDER BY res_dh DESC;";

        /// <summary>
        /// Récupère le nombre de table maximum par batiment
        /// </summary>
        public static string restaurantGetMaxTableBatiment =
            "SELECT MAX(tab_id) AS NB_TABLES_MAX FROM `Table` WHERE Restaurant_resto_bat_id = @batId";

        /// <summary>
        /// Récupère le nombre de tables réservées pour un batiment et une date
        /// </summary>
        public static string restaurantGetNombreTablesReservees =
                @"SELECT COUNT(Table_tab_id) AS NB_TABLES_TAKEN FROM `reserverRestaurant` 
                                                                    WHERE Table_Restaurant_resto_bat_id = @batId and res_dh LIKE @date AND (status_id = 1 OR status_id = 2)"
            ;

        /// <summary>
        /// Compléter la liste des tables pour chaque restaurant dans la DB
        /// </summary>
        public static string insertTablesSoBoringDude =
            "INSERT INTO `Table` (Restaurant_resto_bat_id, tab_id) VALUES(@idResto, @idTAB);";

        /// <summary>
        /// Rajouter un client pour le restaurant dans la DB
        /// </summary>
        public static string restaurantInsertClient =
            "INSERT INTO Client (cli_nom, cli_tel) VALUES (@nomClient, @telCLient);";

        /// <summary>
        /// Trouver l'id d'un client par le son nom
        /// </summary>
        public static string restaurantFindClientIdByName = "SELECT cli_id FROM Client WHERE cli_nom = @nomClient;";

        /// <summary>
        /// Réservation d'une table
        /// </summary>
        public static string restaurantReserverTable =
            @"INSERT INTO reserverRestaurant (Client_cli_id, res_dh, Table_tab_id, Table_Restaurant_resto_bat_id, status_id)
                                                         VALUES (@idCLIENT, @DATEHEURE, @idTABLE, @idRESTAU, '1');";

        public static string getReservationsByClientDate =
            @"SELECT * FROM reserverRestaurant WHERE Client_cli_id = @clidID AND res_dh = @DATEHEURE AND (status_id = 1 OR status_id = 2)";


        public static string getReservationStatusLabel =
            @"SELECT reservStatus_libelle FROM ReservationStatus WHERE reservStatus_id = @IDRESERVSTATUS";

        public static string updateStatusReservation =
            @"UPDATE reserverRestaurant SET status_id = @STATEID WHERE res_dh = @DATETIME AND Client_cli_id = @CLIID AND status_id = 1";

        public static string launchUpdateStatusReservation =
            @"UPDATE reserverRestaurant SET status_id = @STATEID WHERE res_dh < DATE(NOW()) AND status_id = @CURRENTID";

        public static string getNBValidReservation =
            @"SELECT COUNT(*) FROM reserverRestaurant WHERE res_dh BETWEEN @STARTDT AND @ENDDT AND (status_id = 1 OR status_id = 2) AND Client_cli_id <> @CLIID;";

        public static string getNbAllReservations =
            @"SELECT COUNT(*) FROM reserverRestaurant WHERE res_dh < DATE(NOW())";

        public static string getNbReservationsByStatus =
            @"SELECT COUNT(*) FROM reserverRestaurant WHERE res_dh < DATE(NOW()) AND status_id = @IDSTATUS and Table_Restaurant_resto_bat_id = @BATID ";
    }
}
