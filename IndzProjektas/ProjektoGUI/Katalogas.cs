using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektoGUI
{
    public partial class Katalogas : Form
    {
        const string prekiuD = "produktai.txt";
        List<produktaiclass> prekes = new List<produktaiclass>();
        public Katalogas()
        {
            InitializeComponent();
            //MessageBox.Show("pavyko");
            if (prekes.Count == 0)
                prekes = skaitytiProduktus(prekiuD);
            isvesti();
        }

        private void Katalogas_Load(object sender, EventArgs e)
        {


        }

        static List<produktaiclass> skaitytiProduktus(string pd)
        {
            List<produktaiclass> prekes = new List<produktaiclass>();


            using (StreamReader srautas = new StreamReader(pd, Encoding.GetEncoding(1257)))
            {
                string eilute;
                int tipas;
                string pavadinimas;
                double kaina;
                while ((eilute = srautas.ReadLine()) != null)
                {
                    string[] eilDalis = eilute.Split(';');
                    pavadinimas = eilDalis[0];
                    kaina = double.Parse(eilDalis[1]);
                    tipas = int.Parse(eilDalis[2]);
                    produktaiclass laik = new produktaiclass(tipas, pavadinimas, kaina);
                    prekes.Add(laik);
                }
                return prekes;
            }
        }
        public void isvesti()
        {
            
            kataloguView.ColumnCount = 3;
            kataloguView.Columns[0].Name = "Pavadinimas";
            kataloguView.Columns[0].Width = 100;
            kataloguView.Columns[1].Name = "Tipas";
            kataloguView.Columns[1].Width = 100;
            kataloguView.Columns[2].Name = "Kaina";
            kataloguView.Columns[2].Width = 60;

            for (int i = 0; i < prekes.Count; i++)
            {
                switch (prekes[i].tipas)
                {
                    case 1:
                        kataloguView.Rows.Add(prekes[i].pavadinimas, "Darzoves", prekes[i].kaina);
                        break;
                    case 2:
                        kataloguView.Rows.Add(prekes[i].pavadinimas, "Vaisiai", prekes[i].kaina);
                        break;
                    case 3:
                        kataloguView.Rows.Add(prekes[i].pavadinimas, "Gerymai", prekes[i].kaina);
                        break;
                    case 4:
                        kataloguView.Rows.Add(prekes[i].pavadinimas, "Pieno produktai", prekes[i].kaina);
                        break;
                    case 5:
                        kataloguView.Rows.Add(prekes[i].pavadinimas, "Riesutai", prekes[i].kaina);
                        break;
                    case 6:
                        kataloguView.Rows.Add(prekes[i].pavadinimas, "Konditerija", prekes[i].kaina);
                        break;

                }
            }
        }
    }
}
