using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe6
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            //Variable declaration
            char ch;
            int num;

            //Print the user for enter one character
            Console.WriteLine("Entrer un character s.v.p: ");
            
            //Read one character from concole
            ch = Console.ReadKey().KeyChar;

            //Print empty line
            Console.WriteLine();

            //Print the message in case the user choose the vowel character
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch== 'u')
            {
                Console.WriteLine("Vous avez saisi une voyelle.");
            }

            //***********************************************************************//

            //Print the message for obtain the number of character from user
            Console.WriteLine("Entrer le nombre de charachter que vous voulez de saisir:");

            //Read the nimber of array of characters
            while(!(int.TryParse(Console.ReadLine(), out num)))
            {
                Console.WriteLine("Errour de saisi, essayer le encore");
            }
            

            //Invoking the method for printing the array of characters
            Util.AfficherLesChars(num);


            //Read any key before close the console
            Console.ReadKey();

        }
    }
}
