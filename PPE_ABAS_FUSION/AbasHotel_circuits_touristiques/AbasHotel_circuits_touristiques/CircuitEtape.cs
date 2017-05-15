using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
{
    class CircuitEtape
    {
        // etape_id
        public int etape_id { get; set; }
        // etape_libelle
        public string etape_libelle { get; set; }
        // etape_description
        public string etape_description { get; set; }
        // etape_remplacement
        public int etape_remplacement { get; set; }
        // etape_numero
        public int etape_numero { get; set; }
        // etape_heure_depart
        public TimeSpan etape_heure_depart { get; set; }
        // etape_duree
        public int etape_duree { get; set; }
        // etape_statut_id
        public int CircuitStatutEtape_etape_statut_id { get; set; }
        // etape_statut_id
        public int etape_cir_id { get; set; }

        public override string ToString()
        {
            return this.etape_libelle;
        }
    
    }
}
