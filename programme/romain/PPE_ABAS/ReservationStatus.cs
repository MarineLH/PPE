using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ABAS
{
    public class ReservationStatus
    {
        public int reservStatus_id { get; set; }
        public string reservStatus_libelle { get; set; }

        public override string ToString()
        {
            return reservStatus_libelle;
        }
    }
}
