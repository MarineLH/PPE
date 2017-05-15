using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS_RES
{
    public class reserverRestaurant
    {

        public int res_id { get; set; }

        // Client_cli_id
        public int Client_cli_id { get; set; }
        // res_dh
        public DateTime res_dh { get; set; }
        // Table_tab_id
        public int Table_tab_id { get; set; }
        // Table_Restaurant_resto_bat_id
        public int Table_Restaurant_resto_bat_id { get; set; }

        public int status_id { get; set; }

        // Nombre de tables (non présent dans la DB)
        public int nbtables { get; set; }
    }
}
