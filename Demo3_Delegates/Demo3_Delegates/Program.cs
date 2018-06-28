using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Delegates
{
    class Program
    {
        //creation de delegate
        delegate void delegateSimple();
        static void Main(string[] args)
        {
            //instancier un delegate
            delegateSimple monDelegate = new delegateSimple(MethodeADelegeur);

            //faire apple a un delegate 
            monDelegate();
            Console.ReadKey();
        }

        private static void MethodeADelegeur()
        {
            Console.WriteLine("Vous venez d'utiliser un delegue!!");
        }
    }
}
