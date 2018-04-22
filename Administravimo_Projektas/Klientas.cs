using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administravimo_Projektas
{
    class Klientas
    {
        public int ID { get; set; }
        public string vardas { get; set; }
        public string pavarde { get; set; }
        public string miestas { get; set; }
        public string tel { get; set; }
        public string el_pastas { get; set; }
        public int n { get; set; }

        Uzsakymas[] uzsakymai = new Uzsakymas[100];
        public Klientas(int ID, string vardas, string pavarde, string miestas, string tel, string el_pastas)
        {
            this.ID = ID;
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.miestas = miestas;
            this.tel = tel;
            this.el_pastas = el_pastas;
            n = 0;

        }

        public void detiK(int ID, string vardas, string pavarde, string miestas, string tel, string el_pastas)
        {
            this.ID = ID;
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.miestas = miestas;
            this.tel = tel;
            this.el_pastas = el_pastas;

        }

        public Uzsakymas Imti(int nr) { return uzsakymai[nr]; }

        public void Deti(Uzsakymas obj) { uzsakymai[n++] = obj; }

        public int ulenght() { return n; }


        public override string ToString()
        {
            string eilute;
            eilute = string.Format("|{0, -13}|{1,-8}|{2,-13}|     {3,-7}   |   {4,3}     | {5,5} | :", ID, vardas, pavarde, miestas, tel, el_pastas);
            return eilute;
        }

        
    }
}
