using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Dapper;
using MySql.Data.MySqlClient;

namespace PPE_ABAS
{
    public partial class f_Main : Form
    {
        MdiClient client;
        public f_Main()
        {
            InitializeComponent();
            IsMdiContainer = true;
            client = Controls.OfType<MdiClient>().First();
            //This will check whenever client gets focused and there aren't any
            //child forms opened, Send the client to back so that the other controls can be shown back.
            client.GotFocus += (s, e) => {
                if (!MdiChildren.Any(x => x.Visible)) client.SendToBack();
            };
        }

        public void ShowForm(Form f)
        {
            client.BringToFront();
            f.Show();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void f_Main_Load(object sender, EventArgs e)
        {
            ms_main.Visible = false;
            this.Text = "INTERNE - Abas";

            // Choisir le premier onglet au chargement
            Form connex = new f_Connex();
            connex.MdiParent = this;
            connex.FormClosed += connex_FormClosed;
            ShowForm(connex);

        }

        void f_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void connex_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Globals.selectedBat != null)
            {
                ms_main.Visible = true;
                lbl_ListeHisto.Visible = true;
                lbl_ListeResas.Visible = true;
            }
            else
            {
                if (MdiChildren.Length == 1 && MdiChildren[0].Name == "f_Connex")
                {
                    f_Main_Load(sender, e);
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changerDeBatimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Les modifications ne seront peut-être pas sauvegardées. Continuer ?", "Changer de batiment", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                this.MdiChildren.OfType<Form>().ToList().ForEach(x => x.Close());

                Globals.selectedBat = null;

                f_Main_Load(sender, e);
            }
        }

        private void resaListeTSItem_Click(object sender, EventArgs e)
        {
            Form resaListe = new f_ReadReservations();
            resaListe.MdiParent = this;
            ShowForm(resaListe);
        }

        private void lbl_ListeResas_Click(object sender, EventArgs e)
        {
            // 0 ou rien : Onglet des résas en cours
            // 1 : Onglet des historiques
            Form resaListe = new f_ReadReservations(0);
            resaListe.MdiParent = this;
            ShowForm(resaListe);
        }

        private void lbl_ListeHisto_Click(object sender, EventArgs e)
        {
            Form resaListe = new f_ReadReservations(1);
            resaListe.MdiParent = this;
            ShowForm(resaListe);
        }

        private void resaAjouterTSItem_Click(object sender, EventArgs e)
        {
            Form addResa = new f_AddReservation();
            addResa.MdiParent = this;
            ShowForm(addResa);
        }

        private void lbl_addResa_Click(object sender, EventArgs e)
        {
            Form addResa = new f_AddReservation();
            addResa.MdiParent = this;
            ShowForm(addResa);
        }

        private void lbl_olvOpen_Click(object sender, EventArgs e)
        {
            Form listOlv = new f_Resas_OLV();
            listOlv.MdiParent = this;
            ShowForm(listOlv);
        }
    }
}
