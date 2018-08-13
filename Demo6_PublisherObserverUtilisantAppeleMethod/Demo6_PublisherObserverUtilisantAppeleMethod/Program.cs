using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantAppeleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coplage forte avec cette structure
            
            //creer le publisher
            Publisher pub = new Publisher();

            //creer le premier observateur
            Observer1 obs1 = new Observer1();

            //changer la valeur a suivre
            Console.Write("saisir une valeur: ");
            int valeur = Int16.Parse(Console.ReadLine());
            pub.notifier(obs1, valeur);
            Console.ReadKey();
        }
    }
}
