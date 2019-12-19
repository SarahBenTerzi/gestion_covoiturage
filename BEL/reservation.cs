using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class reservation
    {
        public int id_reservation { get; set; }
        public int id_offre { get; set; }
        public int id_passager { get; set; }
        public DateTime date_reservation { get; set; }
    }
}
