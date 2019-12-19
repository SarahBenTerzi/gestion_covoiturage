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
    public partial class ajout_offre : Form
    {
        public ajout_offre()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (utilisateurDAO.verif_utilisateur(textBox6.Text, textBox8.Text))
            {
                if(offreDAO.verif_offre(int.Parse(textBox1.Text))==false)
                {
                    offreDAO.insert_offre(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker3.Text), Convert.ToDateTime(dateTimePicker4.Text), int.Parse(textBox4.Text), textBox5.Text, int.Parse(textBox7.Text), comboBox1.Text, comboBox2.Text, int.Parse(textBox6.Text));
                    MessageBox.Show("l'offre est bien ajoutée");
                    this.Close();
                }
                else
                 MessageBox.Show("l'identifiant de l'offre existe déja changez le");
            }
            else
                MessageBox.Show("Vérifier votre mot de passe ou inscrivez-vous si vous ne l'êtes pas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
