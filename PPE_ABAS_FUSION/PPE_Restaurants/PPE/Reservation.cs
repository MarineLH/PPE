using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_RES
{
    public class Reservation
    {
        // res_id
        public int res_id { get; set; }
        // res_date
        public DateTime res_date { get; set; }
        // res_nbJours
        public int res_nbJours { get; set; }
        // Client_cli_id
        public int Client_cli_id { get; set; }
        // CircuiTouristique_cir_id
        public int CircuiTouristique_cir_id { get; set; }
        // Chambre_ch_id
        public int Chambre_ch_id { get; set; }
        // Chambre_Etage_etage_id
        public int Chambre_Etage_etage_id { get; set; }
        // Chambre_Etage_Hotel_hotel_bat_id
        public int Chambre_Etage_Hotel_hotel_bat_id { get; set; }
        // Voiture_voit_id
        public int Voiture_voit_id { get; set; }
        // Facture_fa_id
        public int Facture_fa_id { get; set; }
    }
}
