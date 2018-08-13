using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    class Observer1
    {
        public void EcrireSurEcran(Object publisher, InfoEventArgs timeInformation)
        {
            Simulateur.getInstance().TextObs1 = "Observateur 1:" + timeInformation.valeur;
        }
    }
}
