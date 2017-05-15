using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Hotels
{
    public class TypeChambre
    {
        // tc_id
        public int tc_id { get; set; }
        // tc_qteUnePlace
        public int tc_qteUnePlace { get; set; }
        // tc_qteDeuxPlaces
        public int tc_qteDeuxPlaces { get; set; }
        // tc_libelle
        public string tc_libelle { get; set; }
        // tc_totalPlaces
        public int tc_totalPlaces { get; set; }

        public override string ToString()
        {
            return "Max: " + tc_totalPlaces + " | " + tc_libelle;
        }


    }
}
