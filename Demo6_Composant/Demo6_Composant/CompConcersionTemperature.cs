using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Composant
{
    public class CompConcersionTemperature
    {
        public double ConversionCelsiusToFahr(double celsius)
        {
            return celsius * 9 / 5.0 + 32;
        }
    }
}
