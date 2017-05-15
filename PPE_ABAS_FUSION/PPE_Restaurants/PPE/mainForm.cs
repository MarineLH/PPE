using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using Dapper;
using System.Diagnostics;
using System.IO;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

namespace PPE_ABAS_RES
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.Text = new CultureInfo("fr-FR").TextInfo.ToUpper(Globals.GlobalBat.bat_libelle);

            label3.Text = "  " + Globals.GlobalUser.ToString();

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;

            //Initialisation des strings des éléments
            groupBox1.Text = Strings.restauration;
            tabPage1.Text = Strings.tabSeeDates;
            addReservationTab.Text = Strings.tabAddDate;
            tabPage3.Text = Strings.tabHistoryDate;
            label1.Text = Strings.incomingDates;
            label2.Text = Strings.pastDates;
            label4.Text = Strings.doneTodayDates;
            button1.Text = Strings.chooseBat;
            button2.Text = Strings.quit;
            clientInfoGB.Text = Strings.userInfo;
            timeGB.Text = Strings.times;
            tableGB.Text = Strings.tables;
            nameLB.Text = Strings.nameDD;
            telLB.Text = Strings.telDD;
            labelNbTables.Text = Strings.availableTables;
            dateLB.Text = Strings.dateDD;
            hourLB.Text = Strings.hourDD;
            validateBT.Text = Strings.validate;
            button3.Text = Strings.reload;

            //ON REMPLIT LA LISTE DE TABLES DANS LA DB (une seule fois mais trop long à la main) :p
            //Functions.fillTableListDB();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Terminées",
                    Values = new ChartValues<double> {Functions.getNbgetNbReservationsByStatus(3)},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Modifiées",
                    Values = new ChartValues<double> {Functions.getNbgetNbReservationsByStatus(5)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Annulées",
                    Values = new ChartValues<double> {Functions.getNbgetNbReservationsByStatus(4)},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        //Au chargement du formulaire, remplissage avec les données dynamiquement
        private void mainForm_Load(object sender, EventArgs e)
        {
            //On update le status des réservations dans la base de données (validée => terminée ; en attente => annulée)
            Functions.launchUpdateReservationStatus(2, 3);
            Functions.launchUpdateReservationStatus(1, 4);

            //On créé la liste des réservations pour aujourd'hui
            //En attente
            CreateDataGrid(listView1);
            //Validées / annulées 
            CreateDataGrid(listView3);

            //On créé la liste des réservations passées
            CreateDataGrid(listView2);

            //On remplit la liste des réservations 
            FillDataGrid();

            //On remplit la liste des réservations passées
            FillDataGridHistory();

            //On récupère le nombre de tables libres
            Functions.GetFreeTables(dateTimePicker1, labelNbTables, tablesUD);

            //On vérifie les champs 
            CheckFields();
        }

        //Récupérer le nombre de tables libres selon la date  ==> refactored avec Functions.cs
        private int GetFreeTables()
        {
            //Récupération du nombre de tables déjà réservées 
            var yearDtp = DateTime.Parse(dateTimePicker1.Value.ToString()).Year;

            var monthDtp = DateTime.Parse(dateTimePicker1.Value.ToString()).Month;

            var dayDtp = DateTime.Parse(dateTimePicker1.Value.ToString()).Day;

            var dateComplete = (new DateTime(yearDtp, monthDtp, dayDtp)).ToString("yyyy-MM-dd") + "%";


            var nombreDeTablesLibres = Functions.GetMaxTable() - Functions.GetTakenTable(dateComplete);

            //On met à jour le text du label 
            if (nombreDeTablesLibres != 0)
            {
                labelNbTables.Text = Strings.availableTables + nombreDeTablesLibres;

                tablesUD.Maximum = nombreDeTablesLibres;

                tablesUD.Visible = true;
            }
            else
            {
                var dateDtp = (new DateTime(yearDtp, monthDtp, dayDtp)).ToString("yyyy-MM-dd");
                if (dateDtp == (DateTime.Now).ToString("yyyy-MM-dd"))
                {
                    labelNbTables.Text = Strings.fullTtoday;
                }
                else
                {
                    labelNbTables.Text = Strings.fullThatDay;
                }


                tablesUD.Visible = false;
            }

            return nombreDeTablesLibres;
        }

        //Vérification des champs pour afficher le bouton valider
        private void CheckFields()
        {
            if (nameTB.Text != "" && telTB.Text != "" && GetFreeTables() != 0)
            {
                validateBT.Visible = true;
            }
            else
            {
                validateBT.Visible = false;
            }
        }

        //Créer la liste de réservations
        private void CreateDataGrid(ListView listv)
        {
            var dateHeader = new ColumnHeader();
            var nameHeader = new ColumnHeader();
            var nbTablesHeader = new ColumnHeader();
            var stateHeader = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            dateHeader.Text = Strings.date;
            dateHeader.TextAlign = HorizontalAlignment.Left;
            dateHeader.Width = 200;

            nameHeader.TextAlign = HorizontalAlignment.Left;
            nameHeader.Text = Strings.name;
            nameHeader.Width = 200;

            nbTablesHeader.TextAlign = HorizontalAlignment.Left;
            nbTablesHeader.Text = Strings.tableNumber;
            nbTablesHeader.Width = 200;

            stateHeader.TextAlign = HorizontalAlignment.Left;
            stateHeader.Text = Strings.state;
            stateHeader.Width = 200;


            // Add the headers to the ListView control.
            listv.Columns.Add(dateHeader);
            listv.Columns.Add(nameHeader);
            listv.Columns.Add(nbTablesHeader);
            listv.Columns.Add(stateHeader);
        }

        //Remplir la liste de réservations
        private void FillDataGrid()
        {
            listView1.Items.Clear();

            Functions.fillListView(listView1, Functions.GetWaitingReservations());

            listView3.Items.Clear();

            Functions.fillListView(listView3, Functions.GetValidCancelReservations());
        }

        //Remplit la liste des réservations passées
        private void FillDataGridHistory()
        {
            listView2.Items.Clear();

            Functions.fillListView(listView2, Functions.GetPastReservations());
        }

        //Fermer l'application quand on ferme le form en appuyant sur quitter
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = Strings.warnQuit;
            var caption = Strings.quit;

            var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Fermer l'application quand on ferme le form en appuyant sur quitter
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Bouton QUITTER
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Bouton CHANGER BATIMENT 
        private void button1_Click(object sender, EventArgs e)
        {
            Globals.GlobalBat = null;

            Globals.GlobalUser = null;

            Form fConnex = new Form1();

            fConnex.Show();

            this.Hide();
        }

        //Pour faire boucler le compteur des heures (23 -> 0)
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (hourUD.Value == -1)
            {
                hourUD.Value = 23;
            }
            else if (hourUD.Value == 24)
            {
                hourUD.Value = 0;
            }
        }

        //Pour faire boucler le compteur des minutes ( 0 -> 30 -> 0)
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (minUD.Value == -30)
            {
                minUD.Value = 30;
            }
            else if (minUD.Value == 60)
            {
                minUD.Value = 0;
            }
        }

        //On récupère les tables libres selon la date + vérification pour bouton valider
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Functions.GetFreeTables(dateTimePicker1, labelNbTables, tablesUD);

            CheckFields();
        }

        //Si on a modifié le nom, on vérifie pour bouton valider
        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        //Si on a modifié le tel, on vérifie pour bouton valider
        private void telTB_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        //Tout cacher
        private void HideAll()
        {
            clientInfoGB.Visible = false;
            tableGB.Visible = false;
            timeGB.Visible = false;

            //Button
            validateBT.Visible = false;

            //loading MESSAGE
            loadingLB.Text = Strings.loading;
            loadingLB.Visible = true;
            addReservationTab.Cursor = Cursors.WaitCursor;
        }

        //Tout montrer
        private void ShowAll()
        {
            clientInfoGB.Visible = true;
            tableGB.Visible = true;
            timeGB.Visible = true;

            //loadingMessage
            loadingLB.Visible = false;
            addReservationTab.Cursor = Cursors.Default;
            MessageBox.Show(Strings.reservationCreated, Strings.success, MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CheckFields();
        }

        //reset des champs du  formulaire
        private void ResetFields()
        {
            //TextBox
            nameTB.Text = null;
            telTB.Text = null;


            //NumericUPDOWN
            hourUD.Value = 10;
            minUD.Value = 0;
            tablesUD.Value = 1;

            dateTimePicker1.Value = DateTime.Now;

            Functions.GetFreeTables(dateTimePicker1, labelNbTables, tablesUD);

            CheckFields();
        }

        //Bouton valider la réservation 
        private void validateBT_Click(object sender, EventArgs e)
        {
            var resDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day, Convert.ToInt32(hourUD.Value), Convert.ToInt32(minUD.Value), 0);

            if (resDate < DateTime.Now)
            {
                MessageBox.Show(Strings.selectValidDate, Strings.errorExclamation, MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                progressBar1.Visible = true;
                progressBar1.Increment(10);
                HideAll();
                progressBar1.Increment(10);
                Functions.CreateReservation(dateTimePicker1, nameTB.Text, telTB.Text, hourUD.Value.ToString(),
                    minUD.Value.ToString(), tablesUD, labelNbTables);
                progressBar1.Increment(50);
                ResetFields();
                progressBar1.Increment(10);
                FillDataGrid();
                progressBar1.Increment(20);
                ShowAll();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
            }
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
            {
                contextMenuStrip1.Show(listView1, new Point(e.X, e.Y));
            }
        }

        private void validerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resDH = listView1.SelectedItems[0].SubItems[0].Text;
            var idClient = listView1.SelectedItems[0].Tag.ToString();
            Functions.updateStatusReservation(resDH, idClient, 2);
            tabPage1.Cursor = Cursors.WaitCursor;
            FillDataGrid();
            tabPage1.Cursor = Cursors.Default;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FillDataGrid();
            FillDataGridHistory();
            this.Cursor = Cursors.Default;
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            Functions.storeGlobalReservation(listView1.SelectedItems[0].Tag.ToString(),
                listView1.SelectedItems[0].SubItems[0].Text);

            Form varModifyForm = new modifyForm();
            varModifyForm.Show();
            varModifyForm.TopMost = true;

            varModifyForm.Closed += Form_Closed;
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resDH = listView1.SelectedItems[0].SubItems[0].Text;
            var idClient = listView1.SelectedItems[0].Tag.ToString();
            Functions.updateStatusReservation(resDH, idClient, 4);
            this.Cursor = Cursors.WaitCursor;
            FillDataGrid();
            Functions.GetFreeTables(dateTimePicker1, labelNbTables, tablesUD);
            FillDataGridHistory();
            this.Cursor = Cursors.Default;
        }

        void Form_Closed(object sender, EventArgs e)
        {
            FillDataGrid();
            Functions.GetFreeTables(dateTimePicker1, labelNbTables, tablesUD);
            CheckFields();
            this.Enabled = true;
        }
    }
}
