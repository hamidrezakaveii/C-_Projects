using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe emp1 = new Employe();
            emp1.nom = "kaveh";
            emp1.prenom = "hami";
            emp1.code = "A123";

            Console.WriteLine(Utils.concatenationNomPrenom(emp1.nom, emp1.prenom));
            Utils.modifierCode(emp1);
            Console.WriteLine(emp1.code);
        }
    }
}
