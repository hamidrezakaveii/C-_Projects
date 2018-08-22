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
            //Variable declaration
            int nombre;

            //Print the message to user for enter the number
            Console.WriteLine("Entrer le nombre pour calculer le carré :");

            //Check the user entry
            while (!(int.TryParse(Console.ReadLine(), out nombre)) || nombre < 0)
            {
                Console.WriteLine("Errour de saisi, entrer le nombre: ");
            }

            //Invoke the method carre for calculte the carre of (n)
            MyUtili.carre(nombre);

            //Wait for the key before close the console
            Console.ReadKey();
        }
    }
}
