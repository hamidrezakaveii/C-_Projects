using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intra_Exam
{
    class util
    {

        public static double Remboursement(double montant, double cotisation)
        {
            double remboursement = 0;
            //Remboursement = Montant * 0.15 - cotisation
            remboursement = montant * 0.15 - cotisation;
            return remboursement;
        }
    }
}
