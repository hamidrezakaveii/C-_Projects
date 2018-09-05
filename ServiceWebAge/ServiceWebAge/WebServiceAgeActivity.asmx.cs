using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiceWebAge
{
    /// <summary>
    /// Description résumée de WebServiceAgeActivity
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAgeActivity : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }



        [WebMethod]
        public string MessageAnneChoisir(int dateDeNaissance)
        {
            String messagee = "";
            try
            {


                if (1970 < dateDeNaissance)
                {
                    messagee = "Il est temps d’aller se promener à travers le monde";

                }
                else if (1971 <= dateDeNaissance && dateDeNaissance >= 1980)
                {
                    messagee = "il est temps de commencer à travailler sérieusement";
                }
                else if (1981 <= dateDeNaissance && dateDeNaissance >= 1990)
                {
                    messagee = "Il est grand temps de terminer tes études";
                }
                else if (1991 <= dateDeNaissance && dateDeNaissance >= 2000)
                {
                    messagee = "Fais ce qui te plait, tu as encore le temps!";
                }
                else if(2001 <= dateDeNaissance && dateDeNaissance >= 2010)
                {
                    messagee = "utilisation de ce service non-autorisée !!!";
                }

            }catch(Exception ex)
            {
                //WebServiceDataBase wsgr = new WebServiceDataBase();

            }
            finally
            {
                GetRequestHeaders();
            }

            string info = GetRequestHeaders();

            return messagee+"-"+info;
        }



        public string GetRequestHeaders()
        {
            //HttpContext ctx = HttpContext.Current;
            //if (ctx == null || ctx.Request == null || ctx.Request.Headers == null)
            //{
            //    return string.Empty;
            //}
            //string headers = string.Empty;
            //foreach (string header in ctx.Request.Headers.AllKeys)
            //{
            //    string[] values = ctx.Request.Headers.GetValues(header);
            //    headers += string.Format("{0}: {1}", header, string.Join(",", values));
            //}

            //------------------------------------------------------------------------------------------------

            HttpContext ctx = HttpContext.Current;
            //if (ctx == null || ctx.Request == null || ctx.Request.Headers == null)
            //{
            //    return string.Empty;
            //}
            string headers = string.Empty;
            String NameMachineUser = ctx.Request.LogonUserIdentity.Name;
            DateTime dateTime = DateTime.Now;

            String[] sp = NameMachineUser.Split('\\');
            String username = sp[1];
            String machineName = sp[0];



            String s = machineName + "," + username + "," + dateTime;


            return s;
        }
    }
}
