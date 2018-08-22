using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Variable declaration
            int nombre;

            //Print the message for user
            Console.WriteLine("Entrer le nombre pour calculer les premiers multiples de 5: ");

            //Check the user entry
            while(!(int.TryParse(Console.ReadLine(), out nombre)) || nombre<=0)
            {
                Console.WriteLine("Errour de saisi, entrer le nombre: ");
            }

            //Run the methode for show the multiple of 5
            MultipleOfFive.MultiplierDeCinq(nombre);

            //Wait for the key before close console
            Console.ReadKey();
        }
    }
}
