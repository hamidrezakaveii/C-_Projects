using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9_LinqToObjects
{
    class Model
    {
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int Population { get; set; }


        public Model(string Ville, string Pays, int Population)
        {
            this.Ville = Ville;
            this.Pays = Pays;
            this.Population = Population;
        }



        public override string ToString()
        {
            return "Model: " + Ville + " " + Pays + " " + Population;
        }
    }
}
