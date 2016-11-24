using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ABAS
{
    /// <summary>
    /// Classe globale qui stocke toutes les requêtes SQL qui seront utilisées dans le programme
    /// </summary>
    public static class SQLQueries
    {
        /// <summary>
        /// Récupérer la liste des bâtiments pour la combobox de connexion
        /// </summary>
        public static string connexSelectBatiments = "SELECT * FROM Batiment;";

        /// <summary>
        /// Récupérer le bâtiment sélectionné dans la combobox précédente
        /// </summary>
        public static string connexSelectUnBatiment = "SELECT * FROM Batiment WHERE bat_libelle = @libelle;";

        /// <summary>
        /// Récupérer les réservations pour aujourd'hui et le futur d'un bâtiment
        /// </summary>
        public static string hotelGetReservations = @"SELECT * FROM Reservation 
                                                    WHERE DATE(NOW()) <= DATE(res_dateSortie)
                                                    AND Chambre_Etage_Hotel_hotel_bat_id = @batId";

        /// <summary>
        /// Récupérer les anciennes réservations passées
        /// </summary>
        public static string hotelGetHistorique = @"SELECT * FROM Reservation
                                                    WHERE DATE(res_dateSortie) < DATE(NOW())
                                                    AND Chambre_Etage_Hotel_hotel_bat_id = @batId";

        /// <summary>
        /// Récupère les infos d'un client pour un ID donné
        /// </summary>
        public static string getClientById = "SELECT * FROM Client WHERE cli_id = @cliId";

        /// <summary>
        /// Récupère tous les clients enregistrés dans la base de données
        /// </summary>
        public static string getClients = "SELECT * FROM Client ORDER BY cli_nom, cli_prenom";

        /// <summary>
        /// Ajoute un client
        /// </summary>
        public static string addClient = @"
            CREATE TEMPORARY TABLE IF NOT EXISTS insertedId(id INT, inserted DATETIME);
            INSERT INTO Client(
                cli_nom, cli_prenom, cli_tel, cli_adl1,
                cli_adl2, cli_adcp, cli_adville, cli_mail) 
            VALUES (@cli_nom, @cli_prenom, @cli_tel, @cli_adl1,
                @cli_adl2, @cli_adcp, @cli_adville, @cli_mail);
            INSERT INTO insertedId(id, inserted) VALUES (LAST_INSERT_ID(), NOW());
            SELECT id FROM insertedId ORDER BY inserted DESC LIMIT 1;";

        /// <summary>
        /// Ajoute une réservation
        /// </summary>
        public static string addResa = @"
            INSERT INTO Reservation(
                res_date, res_nbJours, res_dateSortie, Client_cli_id,
                Chambre_ch_id, Chambre_Etage_etage_id, Chambre_Etage_Hotel_hotel_bat_id)
            VALUES (@res_date, @res_nbJours, @res_dateSortie, @Client_cli_id,
                @Chambre_ch_id, @Chambre_Etage_etage_id, @Chambre_Etage_Hotel_hotel_bat_id);";

        /// <summary>
        /// Récupère la liste des types de chambres
        /// </summary>
        public static string getTypesChambres = "SELECT * FROM TypeChambre";

        /// <summary>
        /// Compte le nombre de chambres d'un hôtel disponible dans entre une date
        /// et le nombre de jours.
        /// </summary>
        public static string countNbFreeChambres = @"
            SELECT COUNT(DISTINCT Etage_etage_id, ch_id) as Count FROM Chambre LEFT JOIN Reservation
                ON Chambre.ch_id = Reservation.Chambre_ch_id
                AND Chambre.Etage_etage_id = Reservation.Chambre_Etage_etage_id
                AND Chambre.Etage_Hotel_hotel_bat_id = Reservation.Chambre_Etage_Hotel_hotel_bat_id
                WHERE Chambre.Etage_Hotel_hotel_bat_id = @batId
                  AND ch_type_id = @typeId
                  AND Reservation.res_date IS NULL
                  OR NOT EXISTS( SELECT 1
                                  FROM Reservation
                                  WHERE (res_date > @dateSortie
                                         OR res_dateSortie< @date
                                ));";

        /// <summary>
        /// Récupère la première chambre du résultat du nombre de chambres dispos
        /// </summary>
        public static string selectFreeChambres = @"
            SELECT * FROM Chambre LEFT JOIN Reservation
                ON Chambre.ch_id = Reservation.Chambre_ch_id
                AND Chambre.Etage_etage_id = Reservation.Chambre_Etage_etage_id
                AND Chambre.Etage_Hotel_hotel_bat_id = Reservation.Chambre_Etage_Hotel_hotel_bat_id
                WHERE Chambre.Etage_Hotel_hotel_bat_id = @batId
                  AND ch_type_id = @typeId
                  AND Reservation.res_date IS NULL
                  OR NOT EXISTS( SELECT 1
                                  FROM Reservation
                                  WHERE (res_date > @dateSortie
                                         OR res_dateSortie< @date
                                ));";

        /// <summary>
        /// Récupération d'un client du restaurant avec son cli_id en paramètre
        /// </summary>
        public static string restaurantSelectClientWithId = "SELECT * FROM Client WHERE cli_id = @id;";


        /// <summary>
        /// Récupère la liste des réservations pour un client :
        /// Le nombre de tables pour le client pour une date et heure donnée
        /// En fonction du bâtiment sélectionné  et la date et l'heure d'aujourd'hui
        /// </summary>
        public static string restaurantSelectReservations = @"SELECT*, COUNT(*) AS nbtables FROM reserverRestaurant 
                                                              WHERE res_dh >= DATE(NOW()) AND Table_Restaurant_resto_bat_id = @batId 
                                                              GROUP BY Client_cli_id, res_dh 
                                                              ORDER BY res_dh;";
        /// <summary>
        /// Récupère le nombre de table maximum par batitment
        /// </summary>
        public static string restaurantGetMaxTableBatiment = "SELECT COUNT(*) AS NBTABLES FROM `Table` WHERE Restaurant_resto_bat_id = @batId";
    }
}
