using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceConBd2
{
    internal class Maison
    {

        int id;
        string categorie;
        string ville;
        int prix;
        int propriétaire;

        public Maison() 
        {
            id = 0;
            categorie = string.Empty;
            ville = string.Empty;
            prix = 0;
            propriétaire = 0;
        }

        public Maison(int id, string categorie, string ville, int prix, int propriétaire)
        {
            setId(id);
            setCategorie(categorie);
            this.ville = ville;
            setPrix(prix);
            setProprietaire(propriétaire);
        }

        public int getId() {  return id; }

        public string getCategorie() { return categorie; }

        public string getVille() { return ville; }

        public int getPrix() { return prix; }

        public int getProprietaire() { return propriétaire; }

        public void setId(int id)
        {
            if ( id >= 0 )
            {
                this.id = id;
            }
            else { this.id = 0; }
        }

        public void setPrix(int prix)
        {
            if ( prix >= 0 )
            {
                this.prix = prix;
            }
            else { this.id = 0; }
        }

        public void setCategorie(string categorie)
        {
            if ( categorie == "condo" || categorie == "unifam" || categorie == "jumelé" )
            {
                this.categorie = categorie;
            }
            else { this.categorie = categorie; }
        }

        public void setProprietaire(int proprietaire)
        {
            if ( proprietaire >= 0 )
            {
                this.propriétaire = proprietaire;
            }
            else { this.propriétaire = 0; } 
        }
    }
}
