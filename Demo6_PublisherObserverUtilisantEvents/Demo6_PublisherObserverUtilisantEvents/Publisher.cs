using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_PublisherObserverUtilisantEvents
{

    public delegate void MonDelegate(String input);
    class Publisher
    {
        public int temp { get; set; }

        //declarer Event
        public   MonDelegate ValeurTemperatureChange;

        //methode pour signaler indirectement Event(en utilisant OnXXX)

        public void notifier(int val)
        {
            temp = val;
            //noptifier delegate
            OnValeurTemperatureChange("Demarage: " + temp);
        }

        //methode pour appeler Event d'interet
        public void OnValeurTemperatureChange(String message)
        {
            if (ValeurTemperatureChange != null)
                ValeurTemperatureChange(message);
        }

    }
}
