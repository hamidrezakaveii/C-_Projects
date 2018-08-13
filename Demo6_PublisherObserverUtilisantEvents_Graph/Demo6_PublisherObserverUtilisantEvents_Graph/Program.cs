using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Simulateur objSimulateur = Simulateur.getInstance();
            Application.Run(objSimulateur);
        }
    }
}
