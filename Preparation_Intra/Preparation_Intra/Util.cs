using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intra_Preparation
{
    class Util
    {

        public static Double CalculerIndice(double taille, int masse, int age, int sexe)
        {
            double img = 0;

            //IMG = (1.2 * Masse / Taille * Taille) + (0.23 * age) - (10.8 * S) - 5.4
            //0 pour femme et 1 pour homme

            img = ((1.2 * masse) / (taille * taille)) + (0.23 * age) - (10.8 * sexe) - 5.4;

            
            return img;
        }

        public static string TrouverInterpretation(double img, int sexe)
        {
            string interpretation = "";

            if(sexe == 0)
            {
                if (img < 25)
                    interpretation = "trop maigre";
                else if (25 >= img || img <= 30)
                    interpretation = "normal";
                else if (img > 30)
                    interpretation = "trop de graisse";
            }
            else
            {
                if (img < 15)
                    interpretation = "trop maigre";
                else if (15 >= img || img <= 20)
                    interpretation = "normal";
                else if (img > 20)
                    interpretation = "trop de graisse";
            }

            return interpretation;
        }
    }
}
