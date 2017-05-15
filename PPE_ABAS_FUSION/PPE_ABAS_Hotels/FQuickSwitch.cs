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
using PPE_ABAS_Hotels.Properties;

namespace PPE_ABAS_Hotels
{
    public partial class FQuickSwitch : Form
    {

        public FQuickSwitch()
        {
            InitializeComponent();
        }

        private void FQuickSwitch_Load(object sender, EventArgs e)
        {
            SetTexts();

            IEnumerable<Personnel> utilisateurs;

            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                utilisateurs = connection.Query<Personnel>(SQLQueries.connexSelectUsersByBat,
                    new {batId = Globals.selectedBat.bat_id});
            }

            foreach (Personnel personnel in utilisateurs)
            {
                cb_chooseUser.Items.Add(personnel);
            }
        }

        private void SetTexts()
        {
            this.Text = Resources.f_quick_sw_title;
            groupBox1.Text = Resources.f_quick_sw_select_user;
            bt_val.Text = Resources.val;
        }

        private void bt_val_Click(object sender, EventArgs e)
        {
            if (null != cb_chooseUser.SelectedItem)
            {
                Globals.selectedUser = (Personnel) cb_chooseUser.SelectedItem;
                this.Close();
            }
            else
            {
                MessageBox.Show(Resources.f_quick_sw_select_user, Resources.warning, MessageBoxButtons.OK);
            }
        }
    }
}
