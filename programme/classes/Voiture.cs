﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_Hotel
{
    class Voiture
    {
        // voit_id
        public int voit_id { get; set; }
        // voit_marque
        public string voit_marque { get; set; }
        // voit_modele
        public string voit_modele { get; set; }
        // voit_immat
        public string voit_immat { get; set; }
        // voit_km
        public float voit_km { get; set; }
        // voit_tarifUHT
        public float voit_tarifUHT { get; set; }
        // Hotel_hotel_bat_id
        public int Hotel_hotel_bat_id { get; set; }
        // TVA_tva_id
        public int TVA_tva_id { get; set; }
    }
}
