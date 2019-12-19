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
    public partial class modif_compte : Form
    {
        public modif_compte()
        {
            InitializeComponent();
        }

        private void cin_enter(object sender, EventArgs e)
        {
            if (textBox1.Text=="CIN")
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
            if (textBox4.Text == "Mot de passe")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void mdp_leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Mot de passe";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (utilisateurDAO.verif_utilisateur(textBox1.Text, textBox4.Text))
            {
                utilisateur u = utilisateurDAO.Get_utilisateur(int.Parse(textBox1.Text));

                textBox3.Text = u.nom;
                textBox7.Text = u.prenom;
                textBox5.Text = u.adresse_email;
                textBox6.Text = Convert.ToString(u.numero_telephone);
                dateTimePicker1.Value = u.date_naissance;
                textBox8.Text = u.sexe;
                textBox9.Text = u.MDP;

            }
            else
                MessageBox.Show("Mot de passe erroné essayer de nouveau");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*gerer_compte FR = new gerer_compte();
            FR.ShowDialog();*/
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            { utilisateurDAO.Update_utilisateur(int.Parse(textBox1.Text), textBox3.Text, textBox7.Text, textBox5.Text, int.Parse(textBox6.Text), Convert.ToDateTime(dateTimePicker1.Text), textBox8.Text, textBox9.Text);
                MessageBox.Show("modifications enregistrées :) ");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void a_enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "nouveau mot de passe")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void a_leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "nouveau mot de pass";
                textBox9.ForeColor = Color.Silver;
            }
        }

        private void b_enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Nom")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void b_leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Nom";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void c_enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Prenom")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void c_leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Prenom";
                textBox7.ForeColor = Color.Silver;
            }
        }

        private void d_enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "adresse e-mail")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void d_leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "adresse e-mail";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void e_enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "numero de telephone")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void e_leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "numero de telephone";
                textBox6.ForeColor = Color.Silver;
            }
        }

        private void f_enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "sexe")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void f_leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "sexe";
                textBox8.ForeColor = Color.Silver;
            }
        }*/
    }
}
