using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe7
{
    //class Facturette
    //{
        struct Facturette
        {
            private int qte;
            private string nom;
            private double prix;
            public Facturette(int qte, string nom, double prix)
            {
                this.qte = qte;
                this.nom = nom;
                this.prix = prix;
            }
            // methodes

            public int Qte
            {
                get { return qte; }
                set { qte = value; }
            }
            public string Nom
            {
                get { return nom; }
                set { nom = value; }
            }
            public double Prix
            {
                get { return prix; }
                set { prix = value; }
            }

            public override string ToString()
            {
            return "Item: "+nom+" Prix: "+prix+" Qte:"+qte;
            }
            
            
    }
    //}
}
