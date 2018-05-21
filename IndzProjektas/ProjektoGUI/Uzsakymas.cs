using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektoGUI
{
    class Uzsakymas
    {
        public double suma { get; set; }
        public int uzsakovas { get; set; }
        public string uzsData { get; set; }
        public int pardavejoID { get; set; } 
        public int n { get; set; }
        public produktaiclass[] prekes = new produktaiclass[100];


        public Uzsakymas()
        {

        }

        public Uzsakymas(double suma, int uzsakovas, string uzsData)
        {
            this.suma = suma;
            this.uzsakovas = uzsakovas;
            this.uzsData = uzsData;
        }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format(" {0,2:f2} {1,10} {2,15}  {3,20} ", suma, uzsakovas, uzsData, pardavejoID);
            return eilute;
        }
        public produktaiclass Imti(int nr) { return prekes[nr]; }

        public void Deti(produktaiclass obj) { prekes[n++] = obj; }
        public int plenght() { return n; }
    }
}
