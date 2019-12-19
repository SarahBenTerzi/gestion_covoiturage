using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWinforms
{
    public partial class afficher_coord : Form
    {
        public afficher_coord()
        {
            InitializeComponent();
        }

        private void afficher_coord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_clientsDataSet.utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.db_clientsDataSet.utilisateur);

        }
    }
}
