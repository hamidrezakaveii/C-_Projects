using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo14_WebServiceClient2.ServiceReference1;

namespace demo14_WebServiceClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1SoapClient proxy = new Service1SoapClient();
            

            double resultat = proxy.CalculSoustraction(56, 3);
            Console.WriteLine("resultat est :" + resultat);
            Console.ReadKey();


            
        }
    }
}
