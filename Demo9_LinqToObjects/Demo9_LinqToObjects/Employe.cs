using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9_LinqToObjects
{
    class Employe
    {
        public string _nom{ get; set; }
        public string _prenom { get; set; }
        public double _salaire { get; set; }

        public Employe(string nom, string prenom, double salaire)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._salaire = salaire;
        }

        
        public override string ToString()
        {
            return "Employe: " + _nom + " " + _prenom + " " + _salaire;
        }
    }
}
