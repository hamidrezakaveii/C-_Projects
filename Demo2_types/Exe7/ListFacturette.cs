using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe7
{
    class ListFacturette
    {

        static List<Facturette> fac = new List<Facturette>();

        public static void ajouterFacturette(Facturette f)
        {
            fac.Add(f);
        }

        public static void afficherFacturette()
        {
            double total = 0;
            Console.WriteLine("*********************************Votre Facture**********************************");
            for (int i=0; i<fac.Count; i++)
            {
                string desc = fac[i].Nom;
                double prix = fac[i].Prix;
                int qte = fac[i].Qte;
                total += (fac[i].Qte * fac[i].Prix);

                /*Console.Write("Item:{0}  ", desc);
                Console.Write("Prix:{0}  ", prix);
                Console.WriteLine("Qte:{0}  ", qte);*/
                Console.WriteLine(fac[i]); 
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Totale item achetes est:{0}  ", fac.Count);
            Console.WriteLine("Totale de la facture est:{0}  ",total);
            Console.WriteLine("************************************Merci***************************************");
        }

    }
}
