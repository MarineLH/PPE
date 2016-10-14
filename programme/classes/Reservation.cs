using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_Hotel
{
    class Reservation
    {
        // res_id
        public int resId { get; set; }
        // res_date
        public DateTime resDate { get; set; }
        // res_nbJours
        public int resNbJours { get; set; }
        // Client_cli_id
        public int clientId { get; set; }
        // CircuiTouristique_cir_id
        public int circuitId { get; set; }
        // Chambre_ch_id
        public int chambreId { get; set; }
        // Chambre_Etage_etage_id
        public int etageId { get; set; }
        // Chambre_Etage_Hotel_hotel_bat_id
        public int hotelId { get; set; }
        // Voiture_voit_id
        public int voitureId { get; set; }
        // Facture_fa_id
        public int factureId { get; set; }
    }
}
