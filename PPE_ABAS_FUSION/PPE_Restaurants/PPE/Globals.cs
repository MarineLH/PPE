using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ABAS_RES
{
    public static class Globals
    {
        /// <summary>
        /// String de connexion à la base de données
        /// </summary>
        public static string ConnectionString = "Server = ms-development.fr; Database =  admin_abas; uid = admin_abasUser; pwd = vG9neMzz51";

        public static Batiment GlobalBat;

        public static Personnel GlobalUser;

        public static IEnumerable<reserverRestaurant> TempModifyReserverRestaurant;
        
        

       
    }
}
