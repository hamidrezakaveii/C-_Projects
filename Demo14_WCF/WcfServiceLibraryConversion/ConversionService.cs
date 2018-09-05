using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryConversion
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    class ConversionService : IConversionService
    {
        #region IConversionService Members
        public double ConversionVersFahr(double temp)
        {
            return (2.0 * temp + 32);
            
        }

        public double ConvertVersCelsius(double temp)
        {
            return (temp - 32) / 2.0;
        }

        #endregion
    }
}
