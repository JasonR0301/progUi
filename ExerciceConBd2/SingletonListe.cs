using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceConBd2
{
    internal class SingletonListe
    {

        ObservableCollection<Proprietaire> listeProprietaire;
        ObservableCollection<Maison> listeMaison;
        static SingletonListe instance = null;

        public SingletonListe()
        {
            listeProprietaire = new ObservableCollection<Proprietaire>();
            listeMaison = new ObservableCollection<Maison>();
        }

        public static SingletonListe getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonListe();
            }
            return instance;
        }

        public ObservableCollection<Proprietaire> getListeProprietaires()
        {
            return listeProprietaire;
        }

        public ObservableCollection<Maison> getListeMaisons()
        {
            return listeMaison;
        }

        public void ajouterProprietaire(Proprietaire proprietaire)
        {
            listeProprietaire.Add(proprietaire);
        }

        public void ajouterMaison(Maison maison)
        {
            listeMaison.Add(maison);
        }

        public void retirerProprietaire(int position)
        {
            listeProprietaire.RemoveAt(position);
        }

        public void retirerMaison(int position)
        {
            listeMaison.RemoveAt(position);
        }
    }
}
