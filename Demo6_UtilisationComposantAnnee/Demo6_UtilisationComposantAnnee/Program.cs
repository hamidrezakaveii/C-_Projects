using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo6_ComposantAnnee;

namespace Demo6_UtilisationComposantAnnee
{
    class Program
    {
        static void Main(string[] args)
        {
            Anne myAnne = new Anne();

            Console.WriteLine("SVP enter ton annee de naissance dd-mm-yyyy:");
            String input = Console.ReadLine();
            String[] date = input.Split('-');

            //Console.WriteLine(date[2]);

            DateTime myDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]), 0, 0, 0);

            

            Console.WriteLine(myAnne.MessageAnneChoisir(myDate));

            Console.ReadKey();
        }
    }
}
