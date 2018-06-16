using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer le nombre:");
            string strNum = Console.ReadLine();
            int num = int.Parse(strNum);

            Console.WriteLine("Le carre est: {0}",MyUtili.carre(num));
            Console.ReadKey();
        }
    }
}
