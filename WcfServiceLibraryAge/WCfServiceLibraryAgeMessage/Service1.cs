using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCfServiceLibraryAgeMessage
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string MessageAnneChoisir(string machineName, string machinIP, string username, DateTime dateTime, int anne)
        {
            String messagee = "";

            try
            {


                if (1970 < anne)
                {
                    messagee = "Il est temps d’aller se promener à travers le monde";

                }
                else if (1971 <= anne && anne >= 1980)
                {
                    messagee = "il est temps de commencer à travailler sérieusement";
                }
                else if (1981 <= anne && anne >= 1990)
                {
                    messagee = "Il est grand temps de terminer tes études";
                }
                else if (1991 <= anne && anne >= 2000)
                {
                    messagee = "Fais ce qui te plait, tu as encore le temps!";
                }
                else if (2001 <= anne && anne >= 2010)
                {
                    messagee = "utilisation de ce service non-autorisée !!!";
                }

            }
            catch (Exception ex)
            {
                //WebServiceDataBase wsgr = new WebServiceDataBase();

            }
            finally
            {
                
            }

            

            return messagee;
        }
    }
}
