using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using composantassembly;

namespace Exe1
{
    //creation de delegate
    delegate List<int> afficherDelegate(int[] num);

    class Program
    {


        static void Main(string[] args)
        {
            List<afficherDelegate> registre = new List<afficherDelegate>();

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 

            afficherDelegate a1 = new Util().AfficherPaires;
            afficherDelegate a2 = new Util().AfficherImPaires;
            afficherDelegate a3 = new Util().AfficherPlusCinq;

            registre.Add(a1);
            registre.Add(a2);
            registre.Add(a3);



            foreach (afficherDelegate o in registre)
            {
                List<int> res = o(num);
                foreach (int i in res)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

    }



    class Util
    {
        public List<int> AfficherPaires(int[] num)
        {
            List<int> paire = new List<int>();

            //foreach (var pair in produit)
            foreach (int i in num)
            {
                
                if (i % 2 == 0)
                {
                    paire.Add(i);
                }
            }

            return paire;
        }

        public List<int> AfficherImPaires(int[] num)
        {
            List<int> impaire = new List<int>();

            //foreach (var pair in produit)
            foreach (int i in num)
            {
                if (i % 2 != 0)
                {
                    impaire.Add(i);
                }
            }

            return impaire;
        }

        public List<int> AfficherPlusCinq(int[] num)
        {
            List<int> plusCinq = new List<int>();

            //foreach (var pair in produit)
            foreach (int i in num)
            {
                if (i > 5)
                {
                    plusCinq.Add(i);
                }
            }

            return plusCinq;
        }


    }
    }
