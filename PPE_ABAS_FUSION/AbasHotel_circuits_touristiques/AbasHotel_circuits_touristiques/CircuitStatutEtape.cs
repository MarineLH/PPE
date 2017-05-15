using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
{
    class CircuitStatutEtape
    {
        // etape_statut_id
        public int etape_statut_id { get; set; }
        // statut
        public string statut { get; set; }
                
        public override string ToString()
        {
            return this.statut;
        }
    
    }
}
