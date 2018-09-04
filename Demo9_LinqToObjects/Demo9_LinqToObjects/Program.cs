using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9_LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valeurs = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            var valeur = from data in valeurs
                         where data > 4
                         orderby data descending  //ascending
                         select data;

            //AffichageDonnees(valeur, "Valeur sup a 4");

            ////////////////////////////////////////////////////////////////////////////
            //Exe 9.2
            var employes = new List<Employe>();
            Employe emp1 = new Employe("Jason", "Red", 5000);
            Employe emp2 = new Employe("Ashley", "Green", 7600);
            Employe emp3 = new Employe("Matthew", "Indigo", 3587.5);
            Employe emp4 = new Employe("James", "Indigo", 4700.77);
            Employe emp5 = new Employe("Luke", "Indigo", 6200);

            employes.Add(emp1);
            employes.Add(emp2);
            employes.Add(emp3);
            employes.Add(emp4);
            employes.Add(emp5);
            //Exe 9.2 a et b
            var employe = from data in employes
                          where (data._salaire > 4000) && (data._salaire < 6000)
                          orderby data._nom, data._prenom ascending
                          select data;

            //AffichageDonnees(employe, "");

            //var employe2 = (from data in employes
            //               select data._nom).Distinct();

            //9.2 c
            //var employe2 = employes.Where(Employe => Employe._salaire > 4000 && Employe._salaire < 6000).OrderByDescending(Employe => Employe._nom).ThenBy(Employe => Employe._prenom).Select(Employe => Employe); 
            var employe2 = employes.Select(Employe => Employe._nom).Distinct();

            //AffichageDonnees(employe2, "");

            //Exe 9.2 d
            //var employe3 = from data in employes select new { data._nom, data._prenom };
            var employe3 = employes.Select(Employe => new { Employe._nom, Employe._prenom });

            AffichageDonnees(employe3, "");

            /////////////////////////////////////////////////////////////////////////////////
            //Exe 9.3

            var models = new List<Model>();



        }
        public static void AffichageDonnees<T>(IEnumerable<T> resultat, string texte)
        {
            foreach (var item in resultat)
            {
                Console.WriteLine(item);
            }
        }
    }
}
