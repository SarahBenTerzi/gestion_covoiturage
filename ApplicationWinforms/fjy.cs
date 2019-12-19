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
    public partial class fjy : Form
    {
        public fjy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //accueil FR6 = new accueil();
            //FR6.ShowDialog();
            this.Close();
        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

        private void a_enter(object sender, EventArgs e)
        {
            if ( a.Text == "CIN")
            {
                a.Text = "";
                a.ForeColor = Color.Black ;
            }
        }

        private void a_leave(object sender, EventArgs e)
        {
            if (a.Text == "")
            {
                a.Text = "CIN";
                a.ForeColor = Color.Silver;
            }
        }

        private void b_enter(object sender, EventArgs e)
        {
            if (b.Text == "Nom")
            {
                b.Text = "";
                b.ForeColor = Color.Black;
            }
        }

        private void b_leave(object sender, EventArgs e)
        {
            if (b.Text == "")
            {
                b.Text = "Nom";
                b.ForeColor = Color.Silver;
            }
        }

        private void c_enter(object sender, EventArgs e)
        {
            if (c.Text == "Prenom")
            {
                c.Text = "";
                c.ForeColor = Color.Black;
            }
        }

        private void c_leave(object sender, EventArgs e)
        {
            if (c.Text == "")
            {
                c.Text = "Prenom";
                c.ForeColor = Color.Silver;
            }
        }

        private void d_enter(object sender, EventArgs e)
        {
            if (d.Text == "Sexe")
            {
                d.Text = "";
                d.ForeColor = Color.Black;
            }
        }

        private void d_leave(object sender, EventArgs e)
        {
            if (d.Text == "")
            {
                d.Text = "Sexe";
                d.ForeColor = Color.Silver;
            }
        }

        private void email_enter(object sender, EventArgs e)
        {
            if (email.Text == "NomPrenom@exemple.com")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "NomPrenom@exemple.com";
                email.ForeColor = Color.Silver;
            }
        }

        private void f_enter(object sender, EventArgs e)
        {
            if (f.Text == "Numero de telephone")
            {
                f.Text = "";
                f.ForeColor = Color.Black;
            }
        }

        private void f_leave(object sender, EventArgs e)
        {
            if (f.Text == "")
            {
                f.Text = "Numero de telephone";
                f.ForeColor = Color.Silver;
            }
        }

        private void textBox1_enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Mot de passe")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Mot de passe";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            utilisateurDAO.Insert_utilisateur(int.Parse(a.Text), b.Text, c.Text, email.Text, int.Parse(f.Text), Convert.ToDateTime(dateTimePicker1.Text), d.Text, textBox1.Text);
            MessageBox.Show("vous etes le bienvenu :)");
            this.Close();
        }
    }
}
