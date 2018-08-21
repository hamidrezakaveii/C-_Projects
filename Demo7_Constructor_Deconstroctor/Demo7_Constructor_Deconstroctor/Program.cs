using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo7_Constructor_Deconstroctor
{
    class Program : IDisposable
    {
        static Program()
        {
            Console.WriteLine("Ctor static");
        }

        ~Program()
        {
            Console.WriteLine("Destructor");
        }
        Program()
        {
            Console.WriteLine("Ctor defaut");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            using(Program o = new Program()){
                Console.WriteLine("Utilisation de using");
            }
                

        }

        public void Dispose()
        {
            Console.WriteLine("dans Dispose");
        }
    }
}
