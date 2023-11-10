using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceConBd2
{
    internal class Proprietaire
    {

        int id;
        string nom;
        string prenom;

        public Proprietaire()
        {
            id = 0;
            nom = string.Empty;
            prenom = string.Empty;
        }

        public Proprietaire(int id, string nom, string prenom)
        {
            setId(id);
            this.nom = nom;
            this.prenom = prenom;
        }

        public int getId() {  return id; }

        public string getNom() { return nom; }

        public string getPrenom() { return prenom; }

        public void setId(int id)
        {
            if (id >= 0) 
            {
                this.id = id;
            }
            else { this.id = 0; }
        }
    }
}
