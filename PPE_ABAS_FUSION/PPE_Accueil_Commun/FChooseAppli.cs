using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Accueil_Commun
{
    public partial class FChooseAppli : Form
    {
        public FChooseAppli()
        {
            InitializeComponent();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_hotel_Click(object sender, EventArgs e)
        {
            var fConnex = new PPE_ABAS_Hotels.FConnex();
            fConnex.Show();
        }

        private void bt_resto_Click(object sender, EventArgs e)
        {
            var form1 = new PPE_ABAS_RES.Form1();
            form1.Show();
        }

        private void bt_circuits_Click(object sender, EventArgs e)
        {
            var f_Connex = new PPE_ABAS_Circuits.f_Connex();
            f_Connex.Show();
        }

        private void bt_voitures_Click(object sender, EventArgs e)
        {
            var accueil = new PPE_ABAS_Voit.Accueil();
            accueil.Show();
        }
    }
}
