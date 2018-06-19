using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3
{
    public class MyUtili
    {
        //Static method for calculate the square of (n)
        public static void carre(int num) {

            Console.WriteLine("Le carre de chiffre {0} est: "+num*num);
        }


        //Static method for finding the number (n) is even or odd
        public static void TrouverPairImpair(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine("Le nombre {0} est pair", num);
            }
            else
            {
                Console.WriteLine("Le nombre {0} est impair", num);
            }
        }
    }
}
