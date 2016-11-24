using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace PPE_ABAS
{
    public partial class f_Resas_OLV : Form
    {
        public f_Resas_OLV()
        {
            InitializeComponent();
        }

        private void f_Resas_OLV_Load(object sender, EventArgs e)
        {
            olv_ResClients.CellEditActivation = ObjectListView.CellEditActivateMode.SingleClick;
            olv_ResClients.CellEditStarting += olv_ResClients_OnCellEditStarting;
            olv_ResClients.CellEditFinishing += olv_ResClients_OnCellEditFinishing;
            olv_ResClients.SmallImageList = imageList1;

            olv_date.GroupKeyGetter = delegate (object rowObject)
            {
                ResClient resClient = (ResClient)rowObject;
                return new DateTime(resClient.res_date.Year, resClient.res_date.Month, resClient.res_date.Day);
            };
            olv_date.GroupKeyToTitleConverter = delegate (object groupKey)
            {
                return ((DateTime)groupKey).ToString("dd/MM/yyyy");
            };

            olv_duree.HeaderImageKey = "edit.png";
            olv_duree.ToolTipText = "Seule cette cellule est modifiable.\r\n Elle permet d'allonger la durée du séjour";

            olv_delete.IsEditable = true;
            olv_delete.AspectGetter = delegate
            {
                return "Supprimer";
            };
            olv_delete.ImageGetter = delegate
            {
                return 0;
            };

            Client leClient;
            IEnumerable<Reservation> reservations;
            List<ResClient> resClients = new List<ResClient>();

            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                reservations = connection.Query<Reservation>(SQLQueries.hotelGetReservations, new { batId = Globals.selectedBat.bat_id });

                foreach (Reservation reservation in reservations)
                {
                    leClient = connection.Query<Client>(SQLQueries.getClientById, new { cliId = reservation.Client_cli_id }).Single();
                    resClients.Add(new ResClient(reservation, leClient));
                }
            }
            olv_ResClients.SetObjects(resClients);
            
        }

        private void olv_ResClients_OnCellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column == olv_delete)
            {
                DialogResult dialogResult = MessageBox.Show("Cette action va supprimer l'enregistrement de la base de données ! Continuer ?", "Suppression définitive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;        // we don't want to edit anything
                    ResClient objToDelete = (ResClient)e.RowObject;
                    olv_ResClients.RemoveObject(e.RowObject); // remove object
                    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {
                        try
                        {
                            connection.Execute("DELETE FROM Reservation WHERE res_id = @resId", new { resId = objToDelete.res_id });
                            MessageBox.Show("Cet enregistrement a été supprimé avec succès !", "Succès");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("An error occured : " + exc.Message, exc.HResult.ToString());
                        }
                    }
                }
            }
        }

        private void olv_ResClients_OnCellEditFinishing(object sender, CellEditEventArgs e)
        {
            if (e.Column == olv_duree)
            {
                Debug.Print(((ResClient)e.RowObject).DebugString());
            }
        }
    }
}
