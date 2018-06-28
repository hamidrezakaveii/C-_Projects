using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    delegate bool Observer(int t);

    class Program
    {
        static void Main(string[] args)
        {
            //creation des objet delegate
            Observer m1 = new Ecouteur().EcouteMethod;
            Observer m2 = new printer().PrintMethod;

            //collection de delegate
            List<Observer> registre = new List<Observer>();
            registre.Add(m1);
            registre.Add(m2);

            foreach (Observer tmp in registre)
            {
                tmp(100);
            }

            Console.ReadKey();

        }
    }

    class Ecouteur
    {
        public bool EcouteMethod(int p)
        {
            Console.WriteLine("Ecoute:"+p);
            return true;
        }
    }

    class printer {
        public bool PrintMethod(int q)
        {
            Console.WriteLine("Print:" + q);
            return false;
        }
    }

}
