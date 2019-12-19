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
    public partial class passager : Form
    {
        public passager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerer_compte FR = new gerer_compte();
            FR.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerer_reservation FR1 = new gerer_reservation();
            FR1.ShowDialog();
        }
    }
}
