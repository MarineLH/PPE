using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ABAS_Voit
{
    public class ResClient
    {
        public Reservation res { get; set; }
        public Client client { get; set; }

        public ResClient(Reservation res, Client cli)
        {
            this.res = res;
            this.client = cli;
        }
        public override string ToString()
        {

            return client.cli_nom + " " + client.cli_prenom + " | " + res.res_date;
        }
    }

}
