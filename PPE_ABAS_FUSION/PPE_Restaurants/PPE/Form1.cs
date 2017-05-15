using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace PPE_ABAS_RES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Text = Strings.connection;
            label1.Text = Strings.chooseHotel;
            button1.Text = Strings.validate;
        }

        /// <summary>
        /// Formulaire de choix de batiment
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var batiment in Functions.GetBatiments())
            {
                comboBox1.Items.Add(batiment.bat_libelle);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Functions.SelectGlobalBatByName(comboBox1);
                Form fAuth = new authenticationForm();
                fAuth.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Strings.chooseHotel, Strings.errorExclamation, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
