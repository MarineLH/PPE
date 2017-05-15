using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ABAS_Hotels
{
    public class ResClient
    {
        // res_id
        public int res_id { get; set; }
        // res_date
        public DateTime res_date { get; set; }

        public DateTime res_dateSortie { get; set; }
        // res_nbJours
        public int res_nbJours { get; set; }

        // Chambre_Etage_Hotel_hotel_bat_id
        public int hotel_id { get; set; }
        // cli_nom
        public string cli_nom { get; set; }
        // cli_prenom
        public string cli_prenom { get; set; }

        public string cliFullName { get; set; }
        
        public string numChambre { get; set; }

        public ResClient(Reservation res, Client cli)
        {
            res_id = res.res_id;
            res_date = res.res_date;
            res_nbJours = res.res_nbJours;
            hotel_id = res.Chambre_Etage_Hotel_hotel_bat_id;
            cli_nom = cli.cli_nom;
            cli_prenom = cli.cli_prenom;
            numChambre = res.numChambre;
            cliFullName = cli_nom + " " + cli_prenom;
            res_dateSortie = res.res_dateSortie;
        }
        public override string ToString()
        {

            return cliFullName + " | " + res_date;
        }

        public string DebugString()
        {
            return res_id.ToString() + "; " + res_date.ToString() + "; " + res_nbJours.ToString() + "; "
                + res_dateSortie.ToString() + "; " + hotel_id.ToString() + "; " + numChambre + "; "
                + cliFullName;
        }
    }

}