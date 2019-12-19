using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;

namespace DAL
{
    public class offreDAO
    {
        public static bool verif_offre(int id)
        {
            string requete = String.Format("select * from offre where id_offre ={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            int X=0;
            
            while (rd.Read())
            {
                Console.WriteLine("hello world");
                X = rd.GetInt32(0);
               
            }
            utils.Disconnect();
            if (X == 0)
                return false;
            else
                return true;
        }


        public static bool insert_offre(int a, string b, string c, DateTime d, DateTime e , DateTime f, DateTime g, int h, string i, int j, string k, string l, int m)
        {
            string requete = String.Format("insert into offre values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}');", a,b,c,d,e,f,g,h,i,j,k,l,m);
            return utils.miseajour(requete);
        }


        public static bool verif_lien (int a, int b)
        {
            string requete = String.Format("select cin_conducteur from offre where id_offre ={0};", a);
            OleDbDataReader rd = utils.lire(requete);
            int X = 0;
            while (rd.Read())
            {
                Console.WriteLine("hello world2");
                X = rd.GetInt32(0);
            }
            utils.Disconnect();
            if (X == b)
                return true;
            else
                return false;
        }


        public static offre Get_offre(int id)
        {
            string requete = String.Format("select * from offre where id_offre={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            offre u = new offre();
            while (rd.Read())
            {
                u.id_offre = rd.GetInt32(0);
                u.depart = rd.GetString(1);
                u.arrivee = rd.GetString(2);
                u.date_aller= rd.GetDateTime(3);
                u.date_retour = rd.GetDateTime(4);
                u.heure_aller = rd.GetDateTime(5);
                u.heure_retour = rd.GetDateTime(6);
                u.nbre_places_dispo = rd.GetInt32(7);
                u.etapes = rd.GetString(8);
                u.prix_par_passager= rd.GetInt32(9);
                u.gamme_vehicule = rd.GetString(10);
                u.prcision_supplementaire = rd.GetString(11);
                u.cin_conducteur = rd.GetInt32(12);


            }
            utils.Disconnect();
            return u;
        }



        public static bool Delete_offre(int id)
        {
            Console.WriteLine("supprimer");
            string requete = String.Format("delete from offre where id_offre={0};", id);
            return utils.miseajour(requete);
        }



        public static bool Update_offre(int a, string b, string c, DateTime d, DateTime e, DateTime f, DateTime g, int h, string i, int j, string k, string l)
        {
            string requete = String.Format("update offre set  depart='{0}', arrivee='{1}'," +
                " date_aller='{2}', heure_aller ='{3}',date_retour ='{4}', " +
                " heure_retour ='{5}', nbre_places_dispo = {6}, etapes ='{7}', prix_par_passager={8},"+
                "gamme_vehicule = '{9}', precision_supplementaire ='{10}' where id_offre={11};", b,c,d,e,f,g,h,i,j,k,l,a);
            return utils.miseajour(requete);
        }


        public static offre get_offre_cin ( int cin)
        {
            string requete = String.Format("select * from offre where cin_conducteur ={0};", cin);
            OleDbDataReader rd = utils.lire(requete);
            offre u = new offre();
            while (rd.Read())
            {
                u.id_offre = rd.GetInt32(0);
                u.depart = rd.GetString(1);
                u.arrivee = rd.GetString(2);
                u.date_aller = rd.GetDateTime(3);
                u.date_retour = rd.GetDateTime(4);
                u.heure_aller = rd.GetDateTime(5);
                u.heure_retour = rd.GetDateTime(6);
                u.nbre_places_dispo = rd.GetInt32(7);
                u.etapes = rd.GetString(8);
                u.prix_par_passager = rd.GetInt32(9);
                u.gamme_vehicule = rd.GetString(10);
                u.prcision_supplementaire = rd.GetString(11);
                u.cin_conducteur = rd.GetInt32(12);


            }
            utils.Disconnect();
            return u;
        }


        public static offre get_offre_depart (string ch)
        {
            string requete = String.Format("select * from offre where depart = '{0}';", ch);
            OleDbDataReader rd = utils.lire(requete);
            offre u = new offre();
            while (rd.Read())
            {
                u.id_offre = rd.GetInt32(0);
                u.depart = rd.GetString(1);
                u.arrivee = rd.GetString(2);
                u.date_aller = rd.GetDateTime(3);
                u.date_retour = rd.GetDateTime(4);
                u.heure_aller = rd.GetDateTime(5);
                u.heure_retour = rd.GetDateTime(6);
                u.nbre_places_dispo = rd.GetInt32(7);
                u.etapes = rd.GetString(8);
                u.prix_par_passager = rd.GetInt32(9);
                u.gamme_vehicule = rd.GetString(10);
                u.prcision_supplementaire = rd.GetString(11);
                u.cin_conducteur = rd.GetInt32(12);


            }
            utils.Disconnect();
            return u;
        }


        public static offre get_offre_arrivee (string ch)
        {
            string requete = String.Format("select * from offre where arrivee ='{0}';", ch);
            OleDbDataReader rd = utils.lire(requete);
            offre u = new offre();
            while (rd.Read())
            {
                u.id_offre = rd.GetInt32(0);
                u.depart = rd.GetString(1);
                u.arrivee = rd.GetString(2);
                u.date_aller = rd.GetDateTime(3);
                u.date_retour = rd.GetDateTime(4);
                u.heure_aller = rd.GetDateTime(5);
                u.heure_retour = rd.GetDateTime(6);
                u.nbre_places_dispo = rd.GetInt32(7);
                u.etapes = rd.GetString(8);
                u.prix_par_passager = rd.GetInt32(9);
                u.gamme_vehicule = rd.GetString(10);
                u.prcision_supplementaire = rd.GetString(11);
                u.cin_conducteur = rd.GetInt32(12);


            }
            utils.Disconnect();
            return u;
        }

    }
}
