using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExerciceConBd2
{
    internal class SingletonBd
    {
        static SingletonBd instance = null;
        MySqlConnection con;

        public SingletonBd() 
        {
            con = new MySqlConnection("Server=localhost;Database=ExerciceConBd2;Uid=root;Pwd=root");
        }

        public static SingletonBd getInstance()
        {
            if (instance == null)
                instance = new SingletonBd();
            return instance;
        }

        public ObservableCollection<Proprietaire> getProprietaires()
        {
            SingletonListe.getInstance().getListeProprietaires().Clear();
            try
            {
                MySqlCommand commande = new MySqlCommand("p_get_proprietaires");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();

                MySqlDataReader reader = commande.ExecuteReader();

                while ( reader.Read() == true )
                {
                    int id = (int)reader["id"];
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();

                    Proprietaire proprietaire = new Proprietaire(id, nom, prenom);
                    SingletonListe.getInstance().getListeProprietaires().Add(proprietaire);
                }

                reader.Close();
                con.Close();
            }
            catch (MySqlException ex) 
            {
                catchErrors();
            }
            return SingletonListe.getInstance().getListeProprietaires();
        }

        public ObservableCollection<Maison> getMaisons()
        {
            SingletonListe.getInstance().getListeMaisons().Clear();
            try
            {
                MySqlCommand commande = new MySqlCommand("p_get_maisons");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();

                MySqlDataReader reader = commande.ExecuteReader();

                while ( reader.Read() == true )
                {
                    int id = (int)reader["id"];
                    string categorie = reader["categorie"].ToString();
                    string ville = reader["ville"].ToString();
                    int prix = (int)reader["prix"];
                    int proprietaire = (int)reader["propriétaire"];

                    Maison maison = new Maison(id, categorie, ville, prix, proprietaire);
                    SingletonListe.getInstance().getListeMaisons().Add(maison);
                }

                reader.Close();
                con.Close();
            }
            catch (MySqlException ex) 
            {
                catchErrors();
            }
            return SingletonListe.getInstance().getListeMaisons();
        }

        public void catchErrors()
        {
            if ( con.State == System.Data.ConnectionState.Open )
            {
                con.Close();
            }
        }
    }
}
