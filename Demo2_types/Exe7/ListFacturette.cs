using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe7
{
    class ListFacturette
    {

        static List<Facturette> fac = new List<Facturette>();

        public static void ajouterFacturette(Facturette f)
        {
            fac.Add(f);
        }

        public static void afficherFacturette()
        {
            for (int i=0; i<fac.Count; i++)
            {
                string desc = fac[i].ToString();

            }
        }
    }
}
