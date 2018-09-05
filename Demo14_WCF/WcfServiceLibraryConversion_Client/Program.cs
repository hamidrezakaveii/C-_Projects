using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibraryConversion_Client.ServiceReferenceConversiontemp;


namespace WcfServiceLibraryConversion_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionServiceClient client = new ConversionServiceClient("BasicHttpBinding_IConversionService");
            double resultatFah = client.ConversionVersFahr(19.0);
            Console.WriteLine("Temp en farenheit est:" + resultatFah);
            Console.ReadKey();
        }
    }
}
