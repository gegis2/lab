﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektoGUI
{
    class Klientai
    {
        public int ID { get; set; }
        public string vardas { get; set; }
        public string pavarde { get; set; }
        public string adresas { get; set; }
        public int n { get; set; }
        public Uzsakymas[] uzsakymai = new Uzsakymas[100];
        public Klientai()
        {

        }

        public Klientai (int ID, string vardas, string pavarde,
                        string adresas)
        {
            this.ID = ID;
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.adresas = adresas;
            n = 0;
        }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format(" {0,2:d} {1,15} {2,20}   {3,25}",
                                   ID, vardas, pavarde, adresas);
            return eilute;
        }
        public Uzsakymas Imti(int nr) { return uzsakymai[nr]; }

        public void Deti(Uzsakymas obj) { uzsakymai[n++] = obj; }

        public int ulenght() { return n; }
    }
}
