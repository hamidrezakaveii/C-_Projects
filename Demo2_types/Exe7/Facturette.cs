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
            private int _qte;
            private string _nom;
            private double _prix;
            public Facturette(int qte, string nom, double prix)
            {
                _qte = qte;
                _nom = nom;
                _prix = prix;
            }
            // Definition of the methodes

            public int Qte
            {
                get { return _qte; }
                set { _qte = value; }
            }
            public string Nom
            {
                get { return _nom; }
                set { _nom = value; }
            }
            public double Prix
            {
                get { return _prix; }
                set { _prix = value; }
            }

            public override string ToString()
            {
            return "Item: "+_nom+" Prix: "+_prix+" Qte:"+_qte;
            }
            
            
    }
    //}
}
