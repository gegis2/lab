using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administravimo_Projektas
{
    class Preke
    {
        public int ID;
        public string pavadinimas;
        public double kaina;
        public int kiekis;

        public Preke() { }
        public Preke(int ID, string pavadinimas, double kaina, int kiekis)
        {
            this.ID = ID;
            this.pavadinimas = pavadinimas;
            this.kaina = kaina;
            this.kiekis = kiekis;

        }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format("        |{0, -13}|{1,-8}|{2,-13}|     {3,-7}   |", ID, pavadinimas, kaina, kiekis);
            return eilute;
        }
    }
}
