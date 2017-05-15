using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
{
    class CircuitVehicule
    {
        // vehicule_id
        public int vehicule_id { get; set; }
        // vehicule_immat
        public string vehicule_immat { get; set; }
        // vehicule_permis_chauffeur
        public string vehicule_permis_chauffeur { get; set; }
        // vehicule_type
        public int vehicule_type { get; set; }
       
        public override string ToString()
        {
            return this.vehicule_immat;
        }
    
    }
}
