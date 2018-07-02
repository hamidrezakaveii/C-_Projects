using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulation_N3
{
    //delegate creation 
    delegate double delegateParam(double valA, int valB);
    class Program
    {
        static void Main(string[] args)
        {
            delegateParam myDelegate = new delegateParam(methodForDelegate);
            methodService(myDelegate, "Hami");
            Console.ReadKey();

        }

        private static void methodService(delegateParam p, string txt)
        {
            Console.WriteLine(txt+" The result is: {0:f2}",p(10.0, 4));
        }

        private static double methodForDelegate(double val1, int val2)
        {
            Console.WriteLine("You are try to use a delegate!");
            return val1 * val2;
        }
    }
}
