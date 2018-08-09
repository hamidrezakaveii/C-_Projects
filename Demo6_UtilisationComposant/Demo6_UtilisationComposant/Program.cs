using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo6_ComposantTemperature;

namespace Demo6_UtilisationComposant
{
    class Program
    {
        static void Main(string[] args)
        {
            CompConversionTemperature comp = new CompConversionTemperature();
            double choice;
            double input;
            double output;
            bool next = true;

            while (next)
            {
                Console.WriteLine("Client  C# choisir une selection \n -1 Conversion de F vers C \n -2 Conversion de C vers F \n3 - quitter");
                choice = double.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    //Conversion de Fahrenheit vers Celcius
                    Console.WriteLine("Donner la temperature en oF:");
                    input = Double.Parse(Console.ReadLine());
                    output = comp.ConversionFahrToCelcius(input);
                    Console.WriteLine(output);
                }
                else if (choice == 2)
                {
                    //Conversion de Celsius vers Fahrenheit
                    Console.WriteLine("Donner la temperature en oC:");
                    input = Double.Parse(Console.ReadLine());
                    output = comp.ConversionCelciusToFahr(input);
                    Console.WriteLine(output);
                }
                else
                {
                    next = false;
                    Console.WriteLine("Rien a fire!");
                }
            }
        }
    }
}
