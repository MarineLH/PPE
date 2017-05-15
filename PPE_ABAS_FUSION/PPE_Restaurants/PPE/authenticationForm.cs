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
    public partial class authenticationForm : Form
    {
        public authenticationForm()
        {
            InitializeComponent();
            groupBox1.Text = Strings.authentication;
            label1.Text = Strings.authenticate;
            button1.Text = Strings.connect;
        }

        private void authenticationForm_Load(object sender, EventArgs e)
        {
            foreach (var personnel in Functions.GetPersonnels())
            {
                comboBox1.Items.Add(personnel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                progressBar1.Visible = true;
                progressBar1.Increment(20);
                this.Cursor = Cursors.WaitCursor;
                Functions.SelectUser(((Personnel)comboBox1.SelectedItem).pers_id);
                progressBar1.Increment(70);
                Form fMain = new mainForm();
                progressBar1.Increment(10);
                fMain.Show();
                this.Cursor = Cursors.Default;
                this.Hide();
            }
            else
            {
                MessageBox.Show(Strings.chooseUser, Strings.errorExclamation, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void authenticationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
