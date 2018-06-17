using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exe2
{
    class Program
    {

        enum Semain { Lundi = 1, Mardi = 2, Mercedi = 3, Jedi = 4, Vendredi = 5, Samedi = 6, Dimanche = 7 };
        static void Main(string[] args)
        {
            //----------1 solution-----------------
            //Using switch case
            /*Console.WriteLine("Entrer le numero entre 1 et 7");
            string strCase = Console.ReadLine();
            //int myCase = int.Parse(strCase);
            //int myCase = Convert.ToInt32(strCase);
            int myCase;
            while(!(int.TryParse(strCase, out myCase)) || myCase < 1 || myCase > 7)
            {
                Console.WriteLine("Le numero est incorrect...");
                Console.WriteLine("Entrer le numero entre 1 et 7");
                strCase = Console.ReadLine();
            }
   
            switch(myCase){
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
            }
            Console.ReadKey();*/


            //-------------2 solution---------------------
            //Using class enum
            /*Console.WriteLine("Entrer le numero entre 1 et 7");
            string strCase = Console.ReadLine();
            int myCase = int.Parse(strCase);
            Console.WriteLine(Enum.GetName(typeof(Semain), myCase));
            Console.ReadKey();*/

            //------------3 solution----------------------
            //Using DayOfWeek enum
            Console.WriteLine("Entrer le numero entre 1 et 7");
            string strCase = Console.ReadLine();
            int myCase = int.Parse(strCase);
            Console.WriteLine("The day is: {0}",(Enum.GetName(typeof(DayOfWeek), myCase)));
            

            //------------4 solution----------------------
            //Using french language
            DayOfWeek today = (DayOfWeek)myCase;
            string aujour = DateTimeFormatInfo.CurrentInfo.GetDayName(today);
            Console.WriteLine("Le jour est: {0}", aujour);
            Console.ReadKey();
        }
    }
}
