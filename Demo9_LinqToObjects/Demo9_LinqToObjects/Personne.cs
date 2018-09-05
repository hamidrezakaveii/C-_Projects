using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9_LinqToObjects
{
    class Personne
    {

        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }


        public Personne(string prenom, string nom, string ville)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.Ville = ville;
        }


        public override string ToString()
        {
            return "Personne: " + Prenom + " " + Nom + " " + Ville;
        }
    }
}
