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
    public partial class Itraukimas : Form
    {
        const string klientuD = "Klientai.txt";
        const string pardavejuD = "Pardavejai.txt";
        List<Klientai> kli = new List<Klientai>();
        List<Pardavejai> pard = new List<Pardavejai>();
        public Itraukimas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool arba = false;
            int IDLaik = int.Parse(ID.Text);
            if (darbuotojas.Checked == true)
            {
                if (pard.Count != 0)
                    pard = SkaitytiPardevejus(pardavejuD);
                for (int i = 0; i < pard.Count; i++)
                {
                    if (pard[i].ID == IDLaik)
                    {
                        arba = true;
                        MessageBox.Show("toks pardavejas jau yra");
                    }
                }
                if (arba == false)
                    using (StreamWriter sw = File.AppendText(pardavejuD))
                    {
                        sw.Write(Environment.NewLine);
                        sw.Write("{0,0:d}; {1,0}; {2,0}; {3,0}",
                                       Int32.Parse(ID.Text), vardas.Text,
                                       pavarde.Text, adresas.Text);
                        this.Close();
                    }
                arba = false;
            }

            else if (klientas.Checked == true)
            {
                if (kli.Count != 0)
                    kli = SkaitytiPirkejus(klientuD);

                for (int i = 0; i < kli.Count; i++)
                {
                    if (kli[i].ID == IDLaik)
                    {
                        arba = true;
                    }
                }

                if (arba == false)
                    using (StreamWriter sw = File.AppendText(klientuD))
                {
                    sw.Write(Environment.NewLine);
                    sw.Write("{0,0:d}; {1,0}; {2,0}; {3,0}",
                                   Int32.Parse(ID.Text), vardas.Text,
                                   pavarde.Text, adresas.Text);
                }
                arba = false;
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
