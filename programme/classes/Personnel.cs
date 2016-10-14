using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_Hotel
{
    class Personnel
    {
        // pers_id
        public int persId { get; set; }
        // pers_nom
        public string persNom { get; set; }
        // pers_prenom
        public string persPrenom { get; set; }
        // pers_adl1
        public string persAdl1 { get; set; }
        // pers_adcp
        public string persAdcp { get; set; }
        // pers_adville
        public string persAdville { get; set; }
        // pers_tel
        public string persTel { get; set; }
        // pers_mail
        public string persMail { get; set; }
        // pers_homme
        public bool persHomme { get; set; }
        // Batiment_bat_id
        public int batId { get; set; }
        // pers_telp
        public string persTelp { get; set; }
        // pers_adl2
        public string persAdl2 { get; set; }
        // pers_superieur
        public int persSuperieur { get; set; }
    }
}
