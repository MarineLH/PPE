using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
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
        /// Récupérer les réservations pour aujourd'hui et le futur d'un bâtiment
        /// </summary>
        public static string hotelGetReservations = @"SELECT * FROM Reservation 
                                                    WHERE DATE(res_date) >= DATE(NOW()) 
                                                    AND Chambre_Etage_Hotel_hotel_bat_id = @batId";

        public static string getReservatonsCircuits = @"SELECT * FROM Reservation
                                                        INNER JOIN CircuitTouristique ON Reservation.CircuitTouristique_cir_id = CircuitTouristique.cir_id
                                                        INNER JOIN Client ON Reservation.Client_cli_id = Client.cli_id
                                                        WHERE Reservation.CircuitTouristique_cir_id IS NOT NULL";


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


        public static string getCircuitFromReservations = @"SELECT * FROM CircuitTouristique 
                                                            INNER JOIN Reservation 
                                                            ON CircuitTouristique.cir_id = Reservation.CircuitTouristique_cir_id
                                                            WHERE res_id = @res_id";

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


        public static string hotelCircuitReservation = @"UPDATE Reservation 
                                                          SET CircuitTouristique_cir_id = @cir_id, date_circuit = @cir_date, nbParticipantsCircuit = @nb_parti
                                                          WHERE res_id = @res_id"
                                                          ;

        public static string hotelVoitureReserver = @"UPDATE Reservation
                                                        SET Voiture_voit_id = @Voit_id
                                                        WHERE res_id = @res_id 
                                                        ";

        public static string addNewCircuit = @"INSERT INTO CircuitTouristique (cir_libelle, cir_description, cir_langues_parlees, cir_debut_val, cir_fin_val, cir_nb_participants_max, cir_prixUHT, TVA_tva_id, Hotel_hotel_bat_id)
                                                VALUES (@cir_libelle, @cir_desc, @cir_langues, @cir_deb_val, @cir_fin_val, @cir_nb_part_max, @cir_prix, @cir_tva, @cir_hotel_bat_id)";
           
        public static string addNewEtape = @"INSERT INTO CircuitEtape
          (etape_libelle, etape_description, etape_heure_depart, etape_duree, CircuitStatutEtape_etape_statut_id, etape_cir_id)
          VALUES
           (@etp_libelle, @etp_desc, @etp_heure_dep, @etp_duree, @etp_etp_statut, @etp_cir_id )";
    }
}