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
            ////////////////////////////////////////////////////////////////////////////
            //Exe 9.1
            int[] valeurs = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };


            //a.Trouver toutes les valeurs qui sont supérieures à 4 et les afficher.
            //b.Trouver toutes les valeurs qui sont supérieures à 4 et les afficher par ordre croissant
            //c.Trouver toutes les valeurs qui sont supérieures à 4 et les afficher par ordre décroissant

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


            //a.	Trouver tous les employés qui font entre 4000 et 6000 par mois.
            //b.Lister les employés par ordre croissant de nom et prénom
            
            //var employe = employes.Where(Employe => Employe._salaire > 4000 && Employe._salaire < 6000).OrderByDescending(Employe => Employe._nom).ThenBy(Employe => Employe._prenom).Select(Employe => Employe);
            var employe = from data in employes
                          where (data._salaire > 4000) && (data._salaire < 6000)
                          orderby data._nom, data._prenom ascending
                          select data;

            //AffichageDonnees(employe, "");



            //c.	Trouver tous les noms distincts des employés

            //var employe2 = (from data in employes select data._nom).Distinct();
            var employe2 = employes.Select(Employe => Employe._nom).Distinct();

            //AffichageDonnees(employe2, "");

            //d.	Lister tous les employés (nom et prénom) en utilisant des objets de type anonyme
            //var employe3 = from data in employes select new { data._nom, data._prenom };
            var employe3 = employes.Select(Employe => new { Employe._nom, Employe._prenom });

            //AffichageDonnees(employe3, "");

            /////////////////////////////////////////////////////////////////////////////////
            //Exe 9.3




            ////////////////////////////////////////////////////////////////////////////////
            //Exe 9.4

            var models = new List<Model>();
            models.Add(new Model("London", "UK", 35000));
            models.Add(new Model("Paris", "France", 25000));
            models.Add(new Model("Lagos", "Nigeria", 45000));
            models.Add(new Model("Rome", "Italie", 15000));
            models.Add(new Model("New York", "USA", 125000));
            models.Add(new Model("Chicago", "USA", 105000));
            models.Add(new Model("Oslo", "Norvege", 5000));
            models.Add(new Model("Boston", "USA", 45000));
            models.Add(new Model("Baltimore", "USA", 65000));
            models.Add(new Model("Accra", "Ghana", 25000));
            models.Add(new Model("Milan", "Italie", 15000));

            var personnes = new List<Personne>();
            personnes.Add(new Personne("Bill", "Tages", "New York"));
            personnes.Add(new Personne("Olanjo", "Bobard", "Lagos"));
            personnes.Add(new Personne("Alain", "FlouFlou", "Boston"));
            personnes.Add(new Personne("Wate", "Kinslet", "Paris"));
            personnes.Add(new Personne("Loria", "Soren", "Rome"));
            personnes.Add(new Personne("Tamar", "Kuhl", "Chicago"));
            personnes.Add(new Personne("Romeo", "Unede", "Accra"));
            personnes.Add(new Personne("Simur", "Tarsen", "Oslo"));
            personnes.Add(new Personne("Rudici", "Miluci", "Milan"));
            personnes.Add(new Personne("Bill", "Thorsen", "New York"));
            personnes.Add(new Personne("Avanti", "Sage", "Rome"));
            personnes.Add(new Personne("Billio", "Mustardi", "Rome"));
            personnes.Add(new Personne("Cameo", "Donadi", "Rome"));

            //1.	Afficher le nom des villes ainsi que les personnes qui y vivent.

            Console.WriteLine("Afficher le nom des villes ainsi que les personnes qui y vivent");
            var query1 = models.Join(personnes, Model => Model.Ville, Personne => Personne.Ville, (Model, Personne) => new { models = Model, personnes = Personne }).Select(u => new { u.models.Ville, u.personnes.Nom, u.personnes.Prenom });
            AffichageDonnees(query1, "");
            Console.WriteLine("====================================================================");

            //2.	Afficher le nom de toutes les personnes ainsi que les pays où ils vivent.

            Console.WriteLine("Afficher le nom de toutes les personnes ainsi que les pays où ils vivent.");
            var query2 = personnes.Join(models, Personne => Personne.Ville, Model => Model.Ville, (Personne, Model) => new { personnes = Personne, models = Model }).Select(u => new { u.personnes.Nom, u.personnes.Prenom, u.models.Pays });
            AffichageDonnees(query2, "");
            Console.WriteLine("====================================================================");

            //3.	Afficher toutes les personnes qui vivent à Rome (nom, prénom).

            Console.WriteLine("3.	Afficher toutes les personnes qui vivent à Rome (nom, prénom).");
            var query3 = personnes.Where(Personne => (Personne.Ville == "Rome")).Select(r => new { r.Nom, r.Prenom });
            AffichageDonnees(query3, "");
            Console.WriteLine("====================================================================");

            //4.	Afficher toutes les villes où il y’a plus de 2 personnes qui y vivent.

            Console.WriteLine("4.	Afficher toutes les villes où il y’a plus de 2 personnes qui y vivent.");
            var query4 = personnes.GroupBy(Personne => Personne.Ville ).Select(r => new { City = r.Key, cityCount = r.Count() }).Where(g => g.cityCount >= 2);
            AffichageDonnees(query4, "");
            Console.WriteLine("====================================================================");








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
