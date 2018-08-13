using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantAppeleMethod
{
    class Publisher
    {
        public int temp { get; set; }

        //methode pour signaler le changement de valeur
        public void notifier(Observer1 obj, int val)
        {
            temp = val;
            //notifiert objet observateur par un appel de methode
            obj.EcrireSurEcran("Demarage: "+temp);
        }
    }
}
