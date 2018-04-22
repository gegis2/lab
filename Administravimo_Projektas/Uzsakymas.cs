using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administravimo_Projektas
{
    class Uzsakymas
    {
        public int ID;

        public DateTime dataUzsakymo;

        Preke[] prekes = new Preke[100];
        public int n { get; set; }
        public Uzsakymas() { }

        public Uzsakymas(int ID, DateTime dataUzsakymo)
        {
            this.ID = ID;
            this.dataUzsakymo = dataUzsakymo;
            n = 0;
        }

        public void detiU(int ID, DateTime dataUzsakymo)
        {
            this.ID = ID;
            this.dataUzsakymo = dataUzsakymo;
        }

        public Preke Imti(int nr) { return prekes[nr]; }

        public void Deti(Preke obj) { prekes[n++] = obj; }
        public int plenght() { return n; }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format("    |{0, -13}|{1,-8}|", ID, dataUzsakymo);
            return eilute;
        }
    }
}
