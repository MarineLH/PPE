using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS
{
    public static class Globals
    {
        public static string MySQLConnectionString = "Server=romainvaleye.ovh;Database=admin_abas_db;Uid=admin_abas_user;Pwd=abas_pwd;";
        public static Batiment selectedBat;

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
