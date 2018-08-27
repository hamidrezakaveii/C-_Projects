using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulation_2
{
    class Utils
    {
        Utils util = null;
        public Utils getInstance()
        {
            if(util == null)
            {
                util = new Utils();
            }
            return util;
        }

        public static string concatenationNomPrenom(string nom, string prenom)
        {
            string nomPrenom = "";
            nomPrenom += nom + " - " + prenom;
            return nomPrenom;

        }

        public static void modifierCode(Employe emp)
        {

            if (emp.code.ToUpper().StartsWith("A") || emp.code.ToUpper().StartsWith("B") || emp.code.ToUpper().StartsWith("M") || emp.code.ToUpper().StartsWith("F"))
            {
                emp.code = emp.code + "AXD";
            }
        }
    }
}
