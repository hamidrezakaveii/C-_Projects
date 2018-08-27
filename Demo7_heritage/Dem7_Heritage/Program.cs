using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dem7_Heritage
{
    class Program
    {

        class A
        {
            public virtual void MonCalcul()
            {

            }

            public static void MonToto()
            {
                Console.WriteLine("Base");
            }
        }

        class B : A
        {
            public override void MonCalcul()
            {
                base.MonCalcul();
            }

            public static void MonToto()
            {
                Console.WriteLine("Herité");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            B.MonToto();
        }
    }
}
