using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int nombre;

            //Print the message for user
            Console.WriteLine("Entrer le nombre: ");

            //Check the user entry
            while (!(int.TryParse(Console.ReadLine(), out nombre)) || nombre <= 0)
            {
                Console.WriteLine("Errour de saisi, entrer le nombre: ");
            }

            //Invoking the method from Project Exe3
            Exe3.MyUtili.TrouverPairImpair(nombre);

            //Waiting for the key before close the console 
            Console.ReadKey();
            

        }
    }
}
