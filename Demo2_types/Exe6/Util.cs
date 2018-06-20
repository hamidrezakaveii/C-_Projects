using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe6
{
    class Util
    {
        public static void AfficherLesChars(int n)
        {
            var input = new char[n];
            
            for (var i=0 ; i < input.Length; i++)
            {
                Console.WriteLine("Entrer le {0} character: ", (i+1));
                input[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            Console.WriteLine(); // Linebreak
            Console.Write("Votre entrer pour les {0}  character(s) est: ", n);
            Console.WriteLine(input);
        }
    }
}
