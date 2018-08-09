using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_ComposantTemperature
{
    public class CompConversionTemperature
    {
        /// <summary>
        /// Conversion de temperature de Celsius vers Fahrenheit
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>Valeur de la temperature en fahrenheit</returns>
        public double ConversionCelciusToFahr(double celcius)
        {
            return (int)((celcius * 9) / 5.0 + 32);
        }

        /// <summary>
        /// Conversion de temperature de fahrenheit vers Celcius
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns>Valeur de la temperature en celsius</returns>
        public double ConversionFahrToCelcius(double fahrenheit)
        {
            return (int)((fahrenheit - 32) * 5 / 9.0);
        }

    }
}
