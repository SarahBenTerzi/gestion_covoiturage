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
    public partial class authen_consult : Form
    {
        public authen_consult()
        {
            InitializeComponent();

            utilisateur utl = utilisateurDAO.Get_utilisateur(int.Parse(authentification.test1));
            List<utilisateur> L2 = new List<utilisateur>();
            L2.Add(utl);
            dataGridView1.DataSource = L2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void authen_consult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_clientsDataSet.utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.db_clientsDataSet.utilisateur);

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //gerer_compte FR = new gerer_compte();
            //FR.ShowDialog();
            this.Close();
            
        }
    }
}
