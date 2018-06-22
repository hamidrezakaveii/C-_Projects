using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class PanierAchat
    {   
        //definition de varibles
        private string _noItem;
        private string _nomItem;
        private string _tailleItem;
        private decimal _prixItem;

        //definition de proprieté
        public string NoItem { get{ return _noItem; } set { _noItem = value; } }
        public string NomItem { get { return _nomItem; } set{ _nomItem = value; } }
        public string TailleItem { get { return _tailleItem; } set { if (value.Equals("0")) { TailleItem = "taille inconnue"; } else { _tailleItem = value; } } }
        public decimal PrixItem { get { return _prixItem; } set { if (value < 0) PrixItem = 0; else _prixItem = value; } }

        //definition de constructor 
        public PanierAchat(string no, string nom, string taille, decimal prix)
        {
            NoItem = nom;
            NomItem = nom;
            TailleItem = taille;
            PrixItem = prix;
        }

        //override methode ToString()
        public override string ToString()
        {

            Console.WriteLine("Item#: " + NomItem + " \nDescription: " + NomItem + " \nTaille: " + TailleItem + " \nPrix unitaire: " + PrixItem +" $");
            return "";
        }
        
    }
}

