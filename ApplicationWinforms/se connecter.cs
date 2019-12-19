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
    public partial class se_connecter : Form
    {
        public se_connecter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conducteur FR8 = new conducteur();
            FR8.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            passager FR9 = new passager();
            FR9.ShowDialog();
            
        }

        internal void Shown()
        {
            throw new NotImplementedException();
        }
    }
}
