using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryConversion
{
    [DataContract]
    class Conversion
    {


        [DataMember]
        public string nom;
        [DataMember]
        public double valeur;
        [DataMember]
        public DateTime dataAppel;

    }
}
