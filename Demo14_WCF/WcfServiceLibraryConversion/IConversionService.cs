using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryConversion
{   [ServiceContract]
    public interface IConversionService
    {

        [OperationContract]
        double ConvertVersCelsius(double temp);

        [OperationContract]
        double ConversionVersFahr(double temp);
    }
}
