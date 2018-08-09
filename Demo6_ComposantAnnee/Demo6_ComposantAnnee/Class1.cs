using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_ComposantAnnee
{
    public class Anne
    {
        public String MessageAnneChoisir(DateTime dateDeNaissance)
        {
            String messagee = "";

            if (1970 < dateDeNaissance.Year)
            {
                messagee = "Il est temps d’aller se promener à travers le monde";

            }
            if (1971 <= dateDeNaissance.Year && dateDeNaissance.Year >= 1980)
            {
                messagee = "il est temps de commencer à travailler sérieusement";
            }
            if (1981 <= dateDeNaissance.Year && dateDeNaissance.Year >= 1990)
            {
                messagee = "Il est grand temps de terminer tes études";
            }
            if (1991 <= dateDeNaissance.Year && dateDeNaissance.Year >= 2000)
            {
                messagee = "Fais ce qui te plait, tu as encore le temps!";
            }
            if (2001 <= dateDeNaissance.Year && dateDeNaissance.Year >= 2010)
            {
                messagee = "utilisation de ce service non-autorisée !!!";
            }

            return messagee;
        }
    }
}
