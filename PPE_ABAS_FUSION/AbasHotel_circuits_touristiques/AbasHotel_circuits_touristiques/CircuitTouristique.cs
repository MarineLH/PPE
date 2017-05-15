using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
{
    class CircuitTouristique
    {
        // cir_id
        public int cir_id { get; set; }
        // cir_libelle
        public string cir_libelle { get; set; }
        // cir_description
        public string cir_description { get; set; }
        // cir_duree
        public int cir_duree { get; set; }
        // cir_tarifTTC
        public float cir_prixUHT { get; set; }
        // Hotel_hotel_bat_id
        public int Hotel_hotel_bat_id { get; set; }
        // cir_heure_depart_cir
        public TimeSpan cir_heure_depart { get; set; }
        // cir_heure_arrivee_cir
        public TimeSpan cir_heure_arrivee { get; set; }
        // cir_debut_val_cir
        public DateTime cir_debut_val { get; set; }
        // cir_fin_val_cir
        public DateTime cir_fin_val { get; set; }
        // cir_programme
        public string cir_programme { get; set; }
        // cir_precisions_tarif
        public string cir_precisions_tarif { get; set; }
        // cir_nb_participants_min
        public int cir_nb_participants_min { get; set; }
        // cir_langues_parlees
        public string cir_langues_parlees { get; set; }
        // cir_nb_participants_max
        public int cir_nb_participants_max { get; set; }
        // tva
        public int TVA_tva_id { get; set; }

        public override string ToString()
        {
            return this.cir_libelle;
        }
    
    }
}
