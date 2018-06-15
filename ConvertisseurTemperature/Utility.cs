using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_BasicProject
{
    class Utility
    {

        public static string cversf(string textCel)
        {
            int userCel = int.Parse(textCel);
            int tempFar = (userCel * 2) + 32;
            string textFar = tempFar.ToString();
            return textFar;
        }

        public static string fversc(string textFar)
        {
            int userFar = int.Parse(textFar);
            int tempCel = (userFar - 32) / 2;
            string textCel = tempCel.ToString();
            return textCel;

        }
    }
}
