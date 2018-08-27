using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulation_4
{
    partial class Personne2
    {
        public void AfficheDetailsPersonne(Personne1 pr)
        {
            Console.WriteLine(pr.Nom);
            Console.WriteLine(pr.Prenom);
            Console.WriteLine(pr.Code);
        }



        public static void main()
        {
            Personne1 personne = new Personne1();
            personne.Nom = "Kaveh";
            personne.Prenom = "Hami";
            personne.Code = "123";

            personne.
        }
    }
}
