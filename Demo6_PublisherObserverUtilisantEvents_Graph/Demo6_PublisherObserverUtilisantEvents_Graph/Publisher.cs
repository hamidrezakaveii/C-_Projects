using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantEvents_Graph
{
    class Publisher
    {
        public delegate void MonDelegate(Object publisher, InfoEventArgs timeInformation);

        public int temp { get; set; }

        //declarer Event
        public event MonDelegate ValeurTemperatureChange;

        //methode pour signaler indirectment Event (en utilisant OnXXX)
        public void notifier(int val)
        {
            temp = val;
            //notifier delegue
            InfoEventArgs infoEvent = new InfoEventArgs(temp);
            OnValeurTemperatureChange(this, infoEvent);
        }

        //methode pour appeler Event d'interet
        public void OnValeurTemperatureChange(Object publisher, InfoEventArgs timeInformation)
        {
            if (ValeurTemperatureChange != null)
                ValeurTemperatureChange(publisher, timeInformation);
        }
    }
}
