using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppClient.ServiceReference1;

namespace WindowsFormsAppClient
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Service1Client client = new Service1Client("BasicHttpBinding_IService1");

            DateTime dt = new DateTime();

            string msg = client.MessageAnneChoisir("","","",dt, 1980);



        }
    }
}
