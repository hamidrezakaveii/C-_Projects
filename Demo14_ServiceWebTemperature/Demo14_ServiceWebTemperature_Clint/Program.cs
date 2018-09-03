using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo14_ServiceWebTemperature_Clint.ServiceReferenceTemp;

namespace Demo14_ServiceWebTemperature_Clint
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebServiceTempSoapClient proxy = new WebServiceTempSoapClient();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(proxy));
            

        }
    }
}
