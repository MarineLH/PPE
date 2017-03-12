using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE_ABAS
{
    public static class Globals
    {
        public static string MySQLConnectionString = "Server=romainvaleye.ovh;Database=abas_db;Uid=abas_user;Pwd=3c51713e-534e-4a1d-bc8e-e51c29d3014e;";
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
