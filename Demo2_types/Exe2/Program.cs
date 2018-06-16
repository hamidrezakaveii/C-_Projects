using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2
{
    class Program
    {

        enum Semain { Lundi = 1, Mardi = 2, Mercedi = 3, Jedi = 4, Vendredi = 5, Samedi = 6, Dimanche = 7 };
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir le numero entre 1 et 7");
            string strCase = (Console.ReadLine());
            int myCase = int.Parse(strCase);
            //2
            //bool t = TryParse(strCase, out retour)
            // if(t){}
            //3
            //Convert.ToInt32(strCase);

            //----------1 solution-----------------
            /*switch(myCase){
                case 1:
                    Console.WriteLine("Lundi");
                    break;
                case 2:
                    Console.WriteLine("Mardi");
                    break;
                case 3:
                    Console.WriteLine("Mercedi");
                    break;
                case 4:
                    Console.WriteLine("Jeudi");
                    break;
                case 5:
                    Console.WriteLine("Vendredi");
                    break;
                case 6:
                    Console.WriteLine("Samdi");
                    break;
                case 7:
                    Console.WriteLine("Dimanche");
                    break;
                default:
                    Console.WriteLine("Le nombre n'est pas valid");
                    break;

            }*/

            
            
            //-------------2 solution---------------------
            //Console.WriteLine(Enum.GetName(typeof(Semain), myCase));

            //------------3 solution----------------------
            Console.WriteLine("Le jour est:{0}",(Enum.GetName(typeof(DayOfWeek), myCase)));
            Console.ReadKey();

            //------------4 solution----------------------


        }
    }
}
