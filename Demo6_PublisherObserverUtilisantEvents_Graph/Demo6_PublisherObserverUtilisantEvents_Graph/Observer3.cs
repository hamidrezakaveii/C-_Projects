using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    class Observer3
    {

        public void EcrireSurJauge(Object publisher, InfoEventArgs timeInformation)
        {
            Simulateur.getInstance().jauge.Value = timeInformation.valeur;

        }
    }
}
