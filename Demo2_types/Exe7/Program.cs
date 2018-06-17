using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe7
{
    class Program
    {


        static void Main(string[] args)
        {
            int nombre = 0;
            string nom = "";
            double prix = 0.0;
            int qte = 0;
            Console.WriteLine("Saisir le nombre de article:");

            while(!(int.TryParse(Console.ReadLine(), out nombre)))
            {
                Console.WriteLine("Errour de saisi, essayer encore:");
            }
            //nombre = int.Parse(Console.ReadLine());

            for (int i=0; i<nombre; i++)
            {
                Console.WriteLine("Entrer le nom item:");
                nom = Console.ReadLine();
                Console.WriteLine("Entrer le prix de l'item:");
                prix = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrer la qte de l'item:");
                qte = int.Parse(Console.ReadLine());
                //Facturette fac = new Facturette();
                ListFacturette.ajouterFacturette(new Facturette(qte, nom, prix));
            }

            ListFacturette.afficherFacturette();
            Console.ReadKey();


        }
    }
}
