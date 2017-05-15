using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_Circuits
{
    class CircuitTypeVehicule
    {
        // type_vehi_code
        public int type_vehi_code { get; set; }
        // type_vehi_libelle
        public string type_vehi_libelle { get; set; }
                
        public override string ToString()
        {
            return this.type_vehi_libelle;
        }
    
    }
}
