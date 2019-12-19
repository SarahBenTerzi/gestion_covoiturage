
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;


namespace DAL
{
    public class utilisateurDAO
    {
        public static bool verif_utilisateur(string login, string MDP)
        {
            string requete = String.Format("select MDP from utilisateur where CIN ={0};", login);
            OleDbDataReader rd = utils.lire(requete);
            string X;
            int result = 1 ;
            while (rd.Read())
            {
                Console.WriteLine("verif");
                X = rd.GetString(0);
                result = string.Compare(X, MDP);
            }
            utils.Disconnect();
            if (result == 0)
                return true;
            else
                return false;

        }



        public static bool Insert_utilisateur(int CIN, string nom, string prenom, string adresse_email, int numero_telephone, DateTime date_naissance, string sexe, string MDP)
        {
            Console.WriteLine("insert");
            string requete = String.Format("insert into utilisateur(CIN, nom, prenom, adresse_email, numero_telephone" +
                ", date_naissance, sexe, MDP) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'" +
                ",'{7}');", CIN, nom, prenom, adresse_email, numero_telephone, date_naissance, sexe, MDP);
            return utils.miseajour(requete);
        }



        public static utilisateur Get_utilisateur(int id)
        {
            string requete = String.Format("select * from utilisateur where CIN={0};", id );
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



        public static bool Delete_compte(int id)
        {
            Console.WriteLine("supprimer");
            string requete = String.Format("delete from utilisateur where CIN={0};", id);
            return utils.miseajour(requete);
        }


        public static bool Update_utilisateur(int cin, string nom, string prenom, string mail, int tel, DateTime date, string sexe, string mdp )
        {
            string requete = String.Format("update utilisateur set  nom='{0}', prenom={1}," +
                " adresse_email='{2}', numero_telephone ='{3}', date_naissance ='{4}', " +
                " sexe ='{5}', MDP = '{6}' where CIN={7};", nom, prenom, mail, tel, date, sexe, mdp, cin);
            return utils.miseajour(requete);
        }

    }
}
