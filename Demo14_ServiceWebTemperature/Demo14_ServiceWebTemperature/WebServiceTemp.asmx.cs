using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Demo14_ServiceWebTemperature
{
    /// <summary>
    /// Description résumée de WebServiceTemp
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceTemp : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]

        public double CalculerTemperarure(string caseTemp, double valeur, out string msg)
        {
            double resultat = 0;

            if (caseTemp.Equals("Cel"))
            {
                resultat = (valeur - 32) / 2;

            }
            if (caseTemp.Equals("Far"))
            {
                resultat = (valeur * 2) + 32;

            }

            if (resultat <= 0)
                msg = "Patinage";
            else if (resultat > 0 && resultat < 25)
                msg = "walking";
            else if (resultat >= 25)
                msg = "Swimming";

            else
                msg = "Errour";

            return resultat;
        }
    }
}
