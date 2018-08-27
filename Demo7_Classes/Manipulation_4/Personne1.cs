using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulation_4
{
    partial class Personne1
    {
        private string _nom;
        private string _prenom;
        private string _code;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _nom = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
    }
}
