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

namespace PPE_ABAS_RES
{
    public partial class modifyForm : Form
    {
        public modifyForm()
        {
            InitializeComponent();
        }

        private readonly string cliId = Globals.TempModifyReserverRestaurant.First().Client_cli_id.ToString();

        private void modifyForm_Load(object sender, EventArgs e)
        {
            groupBox1.Text = Strings.modifyReservation;
            label1.Text = Strings.nameDD;
            label2.Text = Strings.telDD;

            textBox1.Text = Functions.GetClientById(int.Parse(cliId)).cli_nom;
            textBox2.Text = Functions.GetClientById(int.Parse(cliId)).cli_tel;
            dateTimePicker1.Value = Globals.TempModifyReserverRestaurant.First().res_dh;
            hourUD.Value = Globals.TempModifyReserverRestaurant.First().res_dh.Hour;
            minUD.Value = Globals.TempModifyReserverRestaurant.First().res_dh.Minute;
            if (Globals.TempModifyReserverRestaurant.Count() <= GetFreeTables())
            {
                numericUpDown1.Value = Globals.TempModifyReserverRestaurant.Count();
            }
            else
            {
                numericUpDown1.Value = GetFreeTables();
            }

            CheckFields();

            GetFreeTables();
        }

        //Vérification des champs pour afficher le bouton valider
        private void CheckFields()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && GetFreeTables() != 0)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private int GetFreeTables()
        {
            //Récupération du nombre de tables déjà réservées 
            var yearDtp = DateTime.Parse(dateTimePicker1.Value.ToString()).Year;

            var monthDtp = DateTime.Parse(dateTimePicker1.Value.ToString()).Month;

            var dayDtp = DateTime.Parse(dateTimePicker1.Value.ToString()).Day;

            var nombreDeTablesLibres = Functions.GetMaxTable() -
                                       Functions.getMaxIdValidReservation(dateTimePicker1, textBox1.Text);

            //On met à jour le text du label 
            if (nombreDeTablesLibres != 0)
            {
                label4.Text = Strings.availableTables + nombreDeTablesLibres;

                numericUpDown1.Maximum = nombreDeTablesLibres;

                numericUpDown1.Visible = true;
            }
            else
            {
                var dateDtp = (new DateTime(yearDtp, monthDtp, dayDtp)).ToString("yyyy-MM-dd");
                if (dateDtp == (DateTime.Now).ToString("yyyy-MM-dd"))
                {
                    label4.Text = Strings.fullTtoday;
                }
                else
                {
                    label4.Text = Strings.fullThatDay;
                }


                numericUpDown1.Visible = false;
            }

            return nombreDeTablesLibres;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hourUD_ValueChanged(object sender, EventArgs e)
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

        private void minUD_ValueChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var resDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day, Convert.ToInt32(hourUD.Value), Convert.ToInt32(minUD.Value), 0);

            if (resDate < DateTime.Now)
            {
                MessageBox.Show(Strings.selectValidDate, Strings.errorExclamation, MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                Functions.updateStatusReservation(Globals.TempModifyReserverRestaurant.First().res_dh.ToString(),
                    Globals.TempModifyReserverRestaurant.First().Client_cli_id.ToString(), 5);
                Functions.CreateReservation(dateTimePicker1, textBox1.Text, textBox2.Text, hourUD.Value.ToString(),
                    minUD.Value.ToString(), numericUpDown1, label3);
                this.Close();
            }

            this.Cursor = Cursors.Default;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetFreeTables();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }
    }
}
