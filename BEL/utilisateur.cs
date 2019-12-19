using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class utilisateur
    {
        public int CIN { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse_email { get; set; }
        public int numero_telephone { get; set; }
        public DateTime date_naissance { get; set; }
        public string sexe { get; set; }
        public int note { get; set; }
        public string MDP { get; set; }
    }
}
