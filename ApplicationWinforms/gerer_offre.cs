using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWinforms
{
    public partial class gerer_offre : Form
    {
        public gerer_offre()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajout_offre FR = new ajout_offre();
            FR.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modif_offre FR2 = new modif_offre();
            FR2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            supp_offre FR3 = new supp_offre();
            FR3.ShowDialog();
        }
    }
}
