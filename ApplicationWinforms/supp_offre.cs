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
    public partial class supp_offre : Form
    {
        public supp_offre()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (offreDAO.verif_lien(int.Parse(textBox1.Text), int.Parse(authentification.test1)))
            {
                offreDAO.Delete_offre(int.Parse(textBox1.Text));
                MessageBox.Show("offre supprimée");

            }
            else
                MessageBox.Show("l'offre n'est pas le votre à supprimer");
        }
    }
}
