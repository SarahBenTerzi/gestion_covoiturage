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
    public partial class modif_offre : Form
    {
        public modif_offre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (offreDAO.verif_lien(int.Parse(textBox1.Text), int.Parse(authentification.test1)))
            {
                offre ofr = offreDAO.Get_offre(int.Parse(textBox1.Text));
                textBox6.Text = Convert.ToString(ofr.cin_conducteur);
                textBox2.Text = ofr.depart;
                textBox3.Text = ofr.arrivee;
                textBox4.Text = Convert.ToString(ofr.nbre_places_dispo);
                textBox5.Text = ofr.etapes;
                textBox7.Text = ofr.depart;
                comboBox2.Text = ofr.prcision_supplementaire;
                comboBox1.Text = ofr.gamme_vehicule;
                dateTimePicker1.Value = ofr.date_aller;
                dateTimePicker2.Value = ofr.date_retour;
                dateTimePicker3.Value = ofr.heure_aller;
                dateTimePicker4.Value = ofr.heure_aller;
            }
            else
                MessageBox.Show("cette offre n'est pas le votre à modifier");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void modif_offre_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                offreDAO.Update_offre(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker3.Value), Convert.ToDateTime(dateTimePicker2.Value), Convert.ToDateTime(dateTimePicker4.Value), int.Parse(textBox4.Text), textBox5.Text, int.Parse(textBox7.Text), comboBox1.Text, comboBox2.Text);
                MessageBox.Show("L'offre est bien modifiée");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
