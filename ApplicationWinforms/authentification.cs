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
    public partial class authentification : Form
    {
        public static String test1="";
        public authentification()
        {
            InitializeComponent();
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            

        }

        private void authentification_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_clientsDataSet.reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.db_clientsDataSet.reservation);
            // TODO: This line of code loads data into the 'db_clientsDataSet.offre' table. You can move, or remove it, as needed.
            this.offreTableAdapter.Fill(this.db_clientsDataSet.offre);
            // TODO: This line of code loads data into the 'db_clientsDataSet.utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.db_clientsDataSet.utilisateur);
            // TODO: This line of code loads data into the 'db_clientsDataSet.utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.db_clientsDataSet.utilisateur);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //accueil FR4 = new accueil();
            //FR4.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                mdpTextBox.UseSystemPasswordChar = false;
            else
                mdpTextBox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (utilisateurDAO.verif_utilisateur(cinComboBox.Text, mdpTextBox.Text))
                {
                    test1 = cinComboBox.Text;
                    se_connecter FR5 = new se_connecter();
                    FR5.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("mot de passe erroné essayer de nouveau");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                

            
        }
    }
}
