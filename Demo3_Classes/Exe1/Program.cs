using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            //definition de variable
            string no;
            string nom;
            string taille;
            decimal prix;
            
            //afficher message pour initialiser des variable
            Console.WriteLine("Entrer le code article");
            no = Console.ReadLine();
            Console.WriteLine("Entrer le nom article");
            nom = Console.ReadLine();
            Console.WriteLine("Entrer la taille article");
            taille = Console.ReadLine();
            Console.WriteLine("Entrer le prix article");
            prix = Convert.ToDecimal(Console.ReadLine());

            //creeration de l'objet
            PanierAchat monPanier = new PanierAchat(no,nom,taille,prix);

            //afficher le resultat
            Console.WriteLine(monPanier);

            //atendre pour le key avant exit le console
            Console.ReadKey();
        }
    }
}
