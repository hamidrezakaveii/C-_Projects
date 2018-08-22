using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulation_N2
{
    //delegate creation
    delegate double delegateAdvance(double valA, int valB);
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate delegate
            delegateAdvance myDelegate = new delegateAdvance(methodeDelegateProduct);
            //delegateAdvance myDelegate = methodeDelegateProduct;

            //invoke delegate
            Console.WriteLine("the result is: {0:f2}",myDelegate(10.0, 4));
            Console.ReadKey();
        }

        private static double methodeDelegateProduct(double val1, int val2)
        {
            Console.WriteLine("You are using a delegate!");
            return val1 * val2;
        }
    }
}
