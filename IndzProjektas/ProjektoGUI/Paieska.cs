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
    public partial class Paieska : Form
    {
        const string klientuD = "Klientai.txt";
        const string pardavejuD = "Pardavejai.txt";
        List<Klientai> kli = new List<Klientai>();
        List<Pardavejai> pard = new List<Pardavejai>();
        public Paieska()
        {
            InitializeComponent();
        }

        private void ieskoti_Click(object sender, EventArgs e)
        {
            if (darbuotojas.Checked == true)
            {
                if(pard.Count ==0 )
                pard = SkaitytiPardevejus(pardavejuD);

                for (int i = 0; i < pard.Count; i++)
                {
                    if (Int32.Parse(ID.Text) == pard[i].ID)
                    {
                        paieskosats.AppendText(pard[i].ToString());
                        paieskosats.AppendText(Environment.NewLine);
                        break;
                    }
                    if (i == pard.Count-1)
                    {
                        MessageBox.Show("Tokio darbuotojo nera");
                    }
                }
            }

            else if (klientas.Checked == true)
            {
                if(kli.Count==0)
                kli = SkaitytiPirkejus(klientuD);

                for (int i = 0; i < kli.Count; i++)
                {
                    if (Int32.Parse(ID.Text) == kli[i].ID)
                    {
                        paieskosats.AppendText(kli[i].ToString());
                        paieskosats.AppendText(Environment.NewLine);
                        break;
                    }
                    if (i == kli.Count-1)
                    {
                        MessageBox.Show("Tokio kliento nera");
                    }

                }
            }

            else MessageBox.Show("pasirinkyte ko ieskote");

        }

        static List<Pardavejai> SkaitytiPardevejus(string pd)
        {
            List<Pardavejai> pardavejai = new List<Pardavejai>();


            using (StreamReader srautas = new StreamReader(pd, Encoding.GetEncoding(1257)))
            {
                string eilute;
                int ID;
                string vardas, pavarde, adresas;
                while ((eilute = srautas.ReadLine()) != null)
                {
                    string[] eilDalis = eilute.Split(';');
                    ID = int.Parse(eilDalis[0]);
                    vardas = eilDalis[1];
                    pavarde = eilDalis[2];
                    adresas = eilDalis[3];
                    Pardavejai laik = new Pardavejai(ID, vardas, pavarde, adresas);
                    pardavejai.Add(laik);
                }
                return pardavejai;
            }
        }

        static List<Klientai> SkaitytiPirkejus(string pd)
        {
            List<Klientai> pardavejai = new List<Klientai>();


            using (StreamReader srautas = new StreamReader(pd, Encoding.GetEncoding(1257)))
            {
                string eilute;
                int ID;
                string vardas, pavarde, adresas;
                while ((eilute = srautas.ReadLine()) != null)
                {
                    string[] eilDalis = eilute.Split(';');
                    ID = int.Parse(eilDalis[0]);
                    vardas = eilDalis[1];
                    pavarde = eilDalis[2];
                    adresas = eilDalis[3];
                    Klientai laik = new Klientai(ID, vardas, pavarde, adresas);
                    pardavejai.Add(laik);
                }
                return pardavejai;
            }
        }

    }
}
