using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_ABAS_Voit
{
    public partial class SaisieMotif : Form
    {
        public Form _parent { get; set; }
        public SaisieMotif()
        {
            InitializeComponent();
        }

        public SaisieMotif(Form parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void SaisieMotif_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((GestionVehicule)_parent).motif = textBox1.Text;
            this.Close();
        }
    }
}
