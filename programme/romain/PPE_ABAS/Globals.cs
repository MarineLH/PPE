using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS
{
    public static class Globals
    {
        public static string MySQLConnectionString = "Server=ms-development.fr;Database=admin_abas;Uid=admin_abasUser;Pwd=vG9neMzz51;";
        public static Batiment selectedBat;
        public static Personnel selectedUser;

        public static string LeadingZero(int num)
        {
            string numero;

            if (num > 0 && num < 10)
                numero = "0" + num.ToString();
            else
                numero = num.ToString();

            return numero;
        }
    }
}
