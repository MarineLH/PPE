using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
{
    class CircuitStatutChauffeur
    {
        // chauffeur_statut_id
        public int chauffeur_statut_id { get; set; }
        // chauffeur_statut_libelle
        public string chauffeur_statut_libelle { get; set; }
                
        public override string ToString()
        {
            return this.chauffeur_statut_libelle;
        }
    
    }
}
