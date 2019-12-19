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
    public partial class resultats_recherche : Form
    {
        public resultats_recherche()
        {
            InitializeComponent();

            offre  ofr = offreDAO.Get_offre(recherche_id.test2);
            Console.WriteLine(ofr.id_offre);
            List<offre> L3 = new List<offre>();
            L3.Add(ofr);
            dataGridView1.DataSource = L3;
        }

        private void resultats_recherche_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilisateurs_offres_reservationsDataSet.offre' table. You can move, or remove it, as needed.
            //this.offreTableAdapter.Fill(this.utilisateurs_offres_reservationsDataSet.offre);
            // TODO: This line of code loads data into the 'utilisateurs_offres_reservationsDataSet.reservation' table. You can move, or remove it, as needed.
            //this.reservationTableAdapter.Fill(this.utilisateurs_offres_reservationsDataSet.reservation);
            // TODO: This line of code loads data into the 'utilisateurs_offres_reservationsDataSet.offre' table. You can move, or remove it, as needed.
            //this.offreTableAdapter.Fill(this.utilisateurs_offres_reservationsDataSet.offre);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
