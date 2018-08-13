using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantEvents
{
    class Driver
    {
        static void Main(string[] args)
        {
            //creer le publisher
            Publisher pub = new Publisher();

            //creer le premier observateur
            Observer1 obs1 = new Observer1();

            //attacher le premier observateur
            pub.ValeurTemperatureChange += new MonDelegate(obs1.EcrireSurEcran);
            //pub.ValeurTemperatureChange -= new MonDelegate(obs1.EcrireSurEcran);
            //pub.ValeurTemperatureChange = null;

            //changer la valeur a suivre
            Console.Write("saisir une valeur: ");
            int valeur = Int16.Parse(Console.ReadLine());
            pub.notifier(valeur);
            Console.ReadKey();
        }
    }
}
