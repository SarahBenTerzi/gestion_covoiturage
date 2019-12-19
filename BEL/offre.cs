using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class offre
    {
        public int id_offre { get; set; }
        public string depart { get; set; }
        public string arrivee { get; set; }
        public DateTime date_aller { get; set; }
        public DateTime heure_aller { get; set; }
        public DateTime date_retour { get; set; }
        public DateTime heure_retour { get; set; }
        public string etapes { get; set; }
        public int nbre_places_dispo { get; set; }
        public int prix_par_passager { get; set; }
        public string gamme_vehicule { get; set; }
        public string prcision_supplementaire { get; set; }
        public int cin_conducteur { get; set; }
    }
}
