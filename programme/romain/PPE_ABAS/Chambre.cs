using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS
{
    public class Chambre
    {
        // Etage_Hotel_hotel_bat_id
        public int Etage_Hotel_hotel_bat_id { get; set; }
        // Etage_etage_id
        public int Etage_etage_id { get; set; }
        // ch_id
        public int ch_id { get; set; }
        // ch_type_id
        public int ch_type_id { get; set; }

        public override string ToString()
        {
            return Etage_etage_id.ToString() + Globals.LeadingZero(ch_id);
        }
    }
}
