using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    class Observer2
    {
        public void EcrireSurEcran1(Object publisher, InfoEventArgs timeInformation)
        {
            Simulateur.getInstance().TextObs2 = "Observateur 2:" + (timeInformation.valeur+23);
        }
    }
}
