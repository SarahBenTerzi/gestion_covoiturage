using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class reservationDAO
    {
        public static bool ajout_reservation (int a, int b, int c)
        {
            string requete = String.Format("insert into reservation " +
                " values ('{0}','{1}','{2}');", a,b,c);
            return utils.miseajour(requete);
        }


        public static bool verif_reservation (int a)
        {
            string requete = String.Format("select * from reservation where id_reservation ={0};", a);
            OleDbDataReader rd = utils.lire(requete);
            int X = 0;

            while (rd.Read())
            {
                Console.WriteLine("hello world5");
                X = rd.GetInt32(0);

            }
            utils.Disconnect();
            if (X == 0)
                return false;
            else
                return true;
        }
    }
}
