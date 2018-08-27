using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulation_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rec1 = new Rectangle(40, 30);
            Rectangle rec2 = new Rectangle();

            //rec2.longeur = 60;
            Console.WriteLine(rec1.longeur);
            Console.WriteLine(rec1.largeur);
            Console.WriteLine(rec2.longeur);
            Console.WriteLine(rec2.largeur);
        }
    }
}
