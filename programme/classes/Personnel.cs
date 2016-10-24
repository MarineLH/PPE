using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS
{
    public class Personnel
    {
        // pers_id
        public int pers_id { get; set; }
        // pers_nom
        public string pers_nom { get; set; }
        // pers_prenom
        public string pers_prenom { get; set; }
        // pers_adl1
        public string pers_adl1 { get; set; }
        // pers_adcp
        public string pers_adcp { get; set; }
        // pers_adville
        public string pers_adville { get; set; }
        // pers_tel
        public string pers_tel { get; set; }
        // pers_mail
        public string pers_mail { get; set; }
        // pers_homme
        public bool pers_homme { get; set; }
        // Batiment_bat_id
        public int Batiment_bat_id { get; set; }
        // pers_telp
        public string pers_telp { get; set; }
        // pers_adl2
        public string pers_adl2 { get; set; }
        // pers_superieur
        public int pers_superieur { get; set; }
    }
}
