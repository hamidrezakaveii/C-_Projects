using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantAppeleMethod
{
    class Observer1
    {
        public void EcrireSurEcran(String mess)
        {
            Console.WriteLine("Observatuer 1: "+mess);
        }
    }
}
