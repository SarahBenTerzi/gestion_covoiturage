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
    public partial class gerer_reservation : Form
    {
        public gerer_reservation()
        {
            InitializeComponent();
            comboBox1.Text = "0";
            comboBox2.Text = "0";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recherche_id FR = new recherche_id();
            //FR.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                offre ofr = offreDAO.Get_offre(int.Parse(comboBox1.Text));
                offre ofr1 = offreDAO.get_offre_cin(int.Parse(comboBox2.Text));
                offre ofr2 = offreDAO.get_offre_depart(textBox1.Text);
                offre ofr3 = offreDAO.get_offre_arrivee(textBox2.Text);
                List<offre> L3 = new List<offre>();
                L3.Add(ofr);
                L3.Add(ofr1);
                L3.Add(ofr2);
                L3.Add(ofr3);
                dataGridView1.DataSource = L3;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gerer_reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilisateurs_offres_reservationsDataSet.utilisateur' table. You can move, or remove it, as needed.
            //this.utilisateurTableAdapter.Fill(this.utilisateurs_offres_reservationsDataSet.utilisateur);
            // TODO: This line of code loads data into the 'utilisateurs_offres_reservationsDataSet.offre' table. You can move, or remove it, as needed.
            //this.offreTableAdapter.Fill(this.utilisateurs_offres_reservationsDataSet.offre);

        }
    }
}
