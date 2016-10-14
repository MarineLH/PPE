using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_Hotel
{
    class CircuitTouristique
    {
        // cir_id
        public int cirId { get; set; }
        // cir_libelle
        public string cirLibelle { get; set; }
        // cir_description
        public string cirDescription { get; set; }
        // cir_duree
        public int cirDuree { get; set; }
        // cir_tarifTTC
        public float cirTarifTTC { get; set; }
        // Hotel_hotel_bat_id
        public int hotelId { get; set; }
        // cir_heure_depart_cir
        public TimeSpan cirHeureDepart { get; set; }
        // cir_heure_arrivee_cir
        public TimeSpan cirHeureArrivee { get; set; }
        // cir_debut_val_cir
        public DateTime cirDebutVal { get; set; }
        // cir_fin_val_cir
        public DateTime cirFinVal { get; set; }
        // cir_programme
        public string cirProgramme { get; set; }
        // cir_precisions_tarif
        public string cirPrecisionsTarif { get; set; }
        // cir_nb_participants_min
        public int cirNbParticipantsMin { get; set; }
        // cir_langues_parlees
        public string cirLanguesParlees { get; set; }
        // cir_nb_participants_max
        public int cirNbParticipantsMax { get; set; }
    }
}
