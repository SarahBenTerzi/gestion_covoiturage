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
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authentification FR = new authentification();
            FR.ShowDialog();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            fjy FR1 = new fjy();
            FR1.ShowDialog();
        }
    }
}
