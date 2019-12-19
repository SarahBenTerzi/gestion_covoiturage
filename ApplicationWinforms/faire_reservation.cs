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
    public partial class faire_reservation : Form
    {
        public faire_reservation()
        {
            InitializeComponent();
        }

        private void faire_reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilisateurs_offres_reservationsDataSet.reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.utilisateurs_offres_reservationsDataSet.reservation);
            // TODO: This line of code loads data into the 'utilisateurs_offres_reservationsDataSet.offre' table. You can move, or remove it, as needed.
            this.offreTableAdapter.Fill(this.utilisateurs_offres_reservationsDataSet.offre);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (offreDAO.verif_offre(int.Parse(comboBox1.Text)) && ! reservationDAO.verif_reservation(int.Parse(comboBox2.Text)))
            {
                reservationDAO.ajout_reservation(int.Parse(comboBox2.Text), int.Parse(comboBox1.Text), int.Parse(authentification.test1));
                MessageBox.Show("reservation enregistrée");
                this.Close();
            }
            else
                MessageBox.Show("changer l'id de la reservation ou verifier l'id de l'offre");
        }
    }
}
