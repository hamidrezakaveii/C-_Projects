using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7_Classes
{
    class BoiteContainer
    {

        private class BoiteInterne
        {
            public int longeur;
            public int largeur;

        }
        static void Main(string[] args)
        {
            BoiteInterne objMagique = new BoiteInterne();
            objMagique.longeur = 30;
            objMagique.largeur = 20;
            Console.WriteLine("longour: " + objMagique.longeur+"\nlargour: "+objMagique.largeur);
        }
    }
}
