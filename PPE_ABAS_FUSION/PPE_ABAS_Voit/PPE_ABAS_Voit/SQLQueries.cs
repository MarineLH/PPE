using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Voit
{
    /// <summary>
    /// Classe globale qui stocke toutes les requêtes SQL qui seront utilisées dans le programme
    /// </summary>
    public static class SQLQueries
    {
        // TODO : Ajouter les requetes SQL sans remplacer

        /// <summary>
        /// Récupérer la liste des bâtiments pour la combobox de connexion
        /// </summary>
        public static string connexSelectBatiments = "SELECT * FROM Batiment;";

        /// <summary>
        /// Récupérer le bâtiment sélectionné dans la combobox précédente
        /// </summary>
        public static string connexSelectUnBatiment = "SELECT * FROM Batiment WHERE bat_libelle = @libelle;";

        /// <summary>
        /// Récupérer les réservations pour aujourd'hui et le futur d'un bâtiment sans voiture
        /// </summary>
        public static string hotelGetReservationsSansVoiture = @"SELECT * FROM Reservation 
                                                    WHERE DATE(res_dateSortie) >= DATE(NOW()) 
                                                    AND Chambre_Etage_Hotel_hotel_bat_id = @batId
                                                    AND Voiture_voit_id is NULL";
        /// <summary>
        /// Récupérer les réservations pour aujourd'hui et le futur d'un bâtiment avec voiture
        /// </summary>
        public static string hotelGetReservationsAvecVoiture = @"SELECT * FROM Reservation 
                                                    WHERE DATE(res_dateSortie) >= DATE(NOW()) 
                                                    AND Chambre_Etage_Hotel_hotel_bat_id = @batId
                                                    AND Voiture_voit_id is not NULL";
        /// <summary>
        /// Récupérer les anciennes réservations passées
        /// </summary>
        public static string hotelGetHistorique = @"SELECT * FROM Reservation
                                                    WHERE DATE(res_date) < DATE(NOW())
                                                    AND Chambre_Etage_Hotel_hotel_bat_id = @batId";

        /// <summary>
        /// Récupère les infos d'un client pour un ID donné
        /// </summary>
        public static string getClientById = "SELECT * FROM Client WHERE cli_id = @cliId";

        /// <summary>
        /// Récupère tous les clients enregistrés dans la base de données
        /// </summary>
        public static string getClients = "SELECT * FROM Client";

       

        /// <summary>
        /// Ajoute un client
        /// </summary>
        public static string addClient = @"INSERT INTO Client(
                                            cli_nom,
                                            cli_prenom,
                                            cli_tel,
                                            cli_adl1,
                                            cli_adl2,
                                            cli_adcp,
                                            cli_adville,
                                            cli_mail) VALUES (
                                            @cliNom,
                                            @cliPrenom,
                                            @cliTel,
                                            @cliAd1,
                                            @cliAd2,
                                            @cliCP,
                                            @cliVille,
                                            @cliMail)";


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

        /// <summary>
        /// Récupérer les voitures pour l'hotel séléctionné 
        /// </summary>
        public static string hotelGetVoitures = @"SELECT * FROM Voiture
                                                    WHERE Hotel_hotel_bat_id = @batId";
        public static string getVoitureById = @"Select * FROM Voiture WHERE voit_id = @voitId";


        public static string hotelVoitureReserver = @"UPDATE Reservation
                                                        SET Voiture_voit_id = @Voit_id
                                                        WHERE res_id = @res_id 
                                                        ";
        public static string SelectVoitureStandard = @"Select * FROM Voiture
                                                          WHERE voit_tarifUHT <= 30
                                                          AND Hotel_hotel_bat_id = @batId
                                                          AND voit_disponible = 1
                                                          AND Voiture.voit_id NOT IN (SELECT DISTINCT Voiture_voit_id FROM Reservation WHERE Voiture_voit_id IS NOT NULL AND res_dateSortie >= NOW())";

        public static string SelectVoitureConfort = @"Select * FROM Voiture
                                                          WHERE voit_tarifUHT BETWEEN 31 AND 50
                                                          AND Hotel_hotel_bat_id = @batId
                                                          AND voit_disponible = 1
                                                          AND Voiture.voit_id NOT IN (SELECT DISTINCT Voiture_voit_id FROM Reservation WHERE Voiture_voit_id IS NOT NULL AND res_dateSortie >= NOW())";

        public static string SelectVoitureLuxe = @"Select * FROM Voiture
                                                          WHERE voit_tarifUHT > 50
                                                          AND Hotel_hotel_bat_id = @batId
                                                          AND voit_disponible = 1
                                                          AND Voiture.voit_id NOT IN (SELECT DISTINCT Voiture_voit_id FROM Reservation WHERE Voiture_voit_id IS NOT NULL AND res_dateSortie >= NOW())";

        public static string AddVehicule = @"INSERT INTO Voiture (voit_marque, voit_modele, voit_immat, voit_km, voit_tarifUHT, TVA_tva_id, Hotel_hotel_bat_id)
                                            VALUES (@marque,@modele,@immat,@km,@tarifUHT,@tva,@batId);";

        public static string DelResVehicule = @"UPDATE Reservation
                                                        SET Voiture_voit_id = NULL
                                                        WHERE res_id = @res_id;";
        public static string SetEtatIndisponible = @"UPDATE Voiture
                                                        SET voit_disponible = 0,
                                                        voit_motif = @motif
                                                        WHERE voit_id = @voit_id;";

        public static string SetEtatDisponible = @"UPDATE Voiture
                                                        SET voit_disponible = 1,
                                                        voit_motif = ''
                                                        WHERE voit_id = @voit_id;";

    }
}