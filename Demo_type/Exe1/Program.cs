using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer ton nom:");
            string nom = Console.ReadLine();
            Console.WriteLine("Votre nom est:{0}" , nom);
            Console.ReadKey();
        }
    }
}
