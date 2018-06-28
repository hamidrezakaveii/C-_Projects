using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1_2
{
    //creation de delegate
    delegate bool afficherDelegate(int num);

    class Program
    {


        static void Main(string[] args)
        {
            afficherDelegate a1 = new Util().IsPair;
            afficherDelegate a2 = new Util().IsImpair;
            afficherDelegate a3 = new Util().IsPlusCinq;

            List<afficherDelegate> registre = new List<afficherDelegate>();
            registre.Add(a1);
            registre.Add(a2);
            registre.Add(a3);

            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);
            num.Add(6);
            num.Add(7);
            num.Add(8);
            num.Add(9);
            num.Add(10);


            List<int> res = new List<int>();

            res = Util.Decouvrir(num, registre[0]);


            foreach (int i in res)
            {

                Console.WriteLine(i);

            }

            Console.ReadKey();

        }




        class Util
        {

            public static List<int> Decouvrir(List<int> num, afficherDelegate ad)
            {
                List<int> resultat = new List<int>();

                foreach (int i in num)
                {
                    if (ad(i))
                    {
                        resultat.Add(i);
                    }
                }


                return resultat;
            }

            public bool IsPair(int num)
            {
                bool resultat = false;
                if (num % 2 == 0)
                {
                    resultat = true;
                }
                return resultat;

            }

            public bool IsImpair(int num)
            {
                bool resultat = false;
                if (num % 2 != 0)
                {
                    resultat = true;
                }
                return resultat;
            }

            public bool IsPlusCinq(int num)
            {
                bool resultat = false;
                if (num > 5)
                {
                    resultat = true;
                }
                return resultat;

            }


        }
    }
}
