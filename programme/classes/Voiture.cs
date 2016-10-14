using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_Hotel
{
    class Voiture
    {
        // voit_id
        public int voitId { get; set; }
        // voit_marque
        public string voitMarque { get; set; }
        // voit_modele
        public string voitModele { get; set; }
        // voit_immat
        public string voitImmat { get; set; }
        // voit_km
        public float voitKm { get; set; }
        // voit_tarifUHT
        public float voitTarifUHT { get; set; }
        // Hotel_hotel_bat_id
        public int hotelId { get; set; }
        // TVA_tva_id
        public int tvaId { get; set; }
    }
}
