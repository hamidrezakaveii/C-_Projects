using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    class InfoEventArgs : EventArgs
    {
        public readonly int valeur;

        public InfoEventArgs(int valeur)
        {
            this.valeur = valeur;
        }
    }
}
