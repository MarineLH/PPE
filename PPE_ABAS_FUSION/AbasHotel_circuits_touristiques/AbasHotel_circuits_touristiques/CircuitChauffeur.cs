using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
{
    class CircuitChauffeur
    {
        // id_chauffeur
        public int id_chauffeur { get; set; }
        // nom_chauffeur
        public string nom_chauffeur { get; set; }
        // prenom_chauffeur
        public string prenom_chauffeur { get; set; }
        // chauffeur_type_permis
        public string chauffeur_type_permis { get; set; }
        // chauffeur_tel
        public int chauffeur_tel { get; set; }
        // chauffeur_statut_id
        public int chauffeur_statut_id { get; set; }
        
        public override string ToString()
        {
            return this.nom_chauffeur;
        }
    
    }
}
