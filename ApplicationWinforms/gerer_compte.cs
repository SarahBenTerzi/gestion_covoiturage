using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using DAL;


namespace ApplicationWinforms
{
    public partial class gerer_compte : Form
    {
        public gerer_compte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authen_consult FR = new authen_consult();
            FR.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supp_compte FR1 = new supp_compte();
            FR1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modif_compte FR2 = new modif_compte();
            FR2.ShowDialog();
        }
    }
}
