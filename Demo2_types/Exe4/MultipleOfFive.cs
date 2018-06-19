using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4
{
    class MultipleOfFive
    {
        //Static methode for print (n) multple of five 
        public static void MultiplierDeCinq(int nombre)
        {
            Console.WriteLine("Les {0} premiers multiples de 5 est:", nombre);
            for (int i = 1; i <= nombre; i++)
            {
                Console.Write(i * 5 + " ");
            }
        }
    }
}
