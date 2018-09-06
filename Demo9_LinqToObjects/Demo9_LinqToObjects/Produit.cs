using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9_LinqToObjects
{
    class Produit
    {
        public string code { get; set; }
        public string nom { get; set; }
        public double prix { get; set; }

        public Produit(string code, string nom, double prix)
        {
            this.code = code;
            this.nom = nom;
            this.prix = prix;
        }




        public override string ToString()
        {
            return "Produit: " + code + " " + nom + " " + prix;
        }

    }
}
