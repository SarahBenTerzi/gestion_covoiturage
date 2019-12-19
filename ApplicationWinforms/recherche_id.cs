using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ApplicationWinforms
{
    public partial class recherche_id : Form
    {
        public static int test2;
        public recherche_id()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (offreDAO.verif_offre(int.Parse(textBox1.Text)))
            {
                resultats_recherche FR = new resultats_recherche();
                FR.ShowDialog();
                test2 = int.Parse(textBox1.Text);
            }
            else
                MessageBox.Show("l'offre n'existe pas");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
