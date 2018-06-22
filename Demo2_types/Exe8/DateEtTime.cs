using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe8
{
    public struct DateEtTime
    {
        private int _annee;
        private int _mois;
        private int _jour;

        public DateEtTime(int annee, int mois, int jour)
        {
            _annee = annee;
            _mois = mois;
            _jour = jour;
        }

        public void AfficherDate()
        {
            Console.WriteLine("Le jour est: " + _annee + "/" + _mois + "/" + _jour);
        }

        public void AdditionDate()
        {
            _jour += 1;
        }

        public void JourDeSemaine()
        {
            
        }
    }

}
