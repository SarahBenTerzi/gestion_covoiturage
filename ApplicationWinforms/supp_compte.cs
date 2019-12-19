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
using BEL;


namespace ApplicationWinforms
{
    public partial class supp_compte : Form
    {
        public supp_compte()
        {
            InitializeComponent();
        }

        private void cin_enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "CIN")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void cin_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "CIN";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void mdp_enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mot de passe")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void mdp_leaver(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Mot de passe";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void supp_compte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gerer_compte FR = new gerer_compte();
            //FR.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (utilisateurDAO.verif_utilisateur(textBox1.Text,textBox2.Text))
            {
                utilisateurDAO.Delete_compte(int.Parse(textBox1.Text));
                MessageBox.Show("compte supprimé");
                this.Close();
                accueil FR = new accueil();
                FR.ShowDialog();
            }
        }
    }
}
