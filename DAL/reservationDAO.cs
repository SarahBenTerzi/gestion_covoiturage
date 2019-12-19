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
        public static offre  get_offre (int id)
        {
            
                string requete = String.Format("select * from offre where id_offre={0};", id);
                OleDbDataReader rd = utils.lire(requete);
                utilisateur u = new utilisateur();
                while (rd.Read())
                {
                    u.CIN = rd.GetInt32(0);
                    u.nom = rd.GetString(1);
                    u.prenom = rd.GetString(2);
                    u.adresse_email = rd.GetString(3);
                    u.numero_telephone = rd.GetInt32(4);
                    u.date_naissance = rd.GetDateTime(5);
                    u.sexe = rd.GetString(6);
                    u.MDP = rd.GetString(7);
                    u.note = rd.GetInt32(8);
                }
                utils.Disconnect();
                return u;
            }
        }
    }
}
