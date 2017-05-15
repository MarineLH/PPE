using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE_ABAS_Circuits
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f_Connex());


            /*string connectionString = @"Data Source= WIN-KOGTC0TJ99C\MSSQL2014;
                                        Initial Catalog= abas_hotel;
                                        Integrated Security= false;
                                        User ID= sa;
                                        Password= MsSQL2014W2012;";
            
            SqlConnection client = new SqlConnection(connectionString);*/
        }
    }
}
