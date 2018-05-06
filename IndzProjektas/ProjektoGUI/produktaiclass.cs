using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektoGUI
{
    public class produktaiclass
    {
        public int kiekis { get; set; }
        public double kaina { get; set; }
        public int tipas { get; set; }
        public string pavadinimas { get; set; }

        public produktaiclass ()
        {

        }

        public produktaiclass(  int tipas, string pavadinimas, double kaina)
        {
            
            this.tipas = tipas;
            this.pavadinimas = pavadinimas;
            this.kaina = kaina;
        }

        public produktaiclass(int tipas, string pavadinimas, double kaina, int kiekis)
        {

            this.tipas = tipas;
            this.pavadinimas = pavadinimas;
            this.kaina = kaina;
            this.kiekis = kiekis;
        }


        public override string ToString()
        {
            string eilute;
            eilute = string.Format("{0,2:d}   {1,10:f2}  {2,15:d}  {3,20}", kiekis, kaina, tipas, pavadinimas);
            return eilute;

        }

        public string ToString1()
        {
            string eilute;
            eilute = string.Format("{0,2},{1,15:f2}", pavadinimas, kaina);
            return eilute;
        }
    }
}
