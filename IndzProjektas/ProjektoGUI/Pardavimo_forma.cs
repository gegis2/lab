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
    public partial class Pardavimo_forma : Form
    {

        const string prekiuD = "produktai.txt";
        const string pardavejuD = "Pardavejai.txt";
        const string klientuD = "Klientai.txt";
        const string kliRez = "Pirkimai.txt";
        List<produktaiclass> prekes = new List<produktaiclass>();
        List<produktaiclass> prekes2 = new List<produktaiclass>();
        List<Klientai> kli = new List<Klientai>();
        List<Pardavejai> pard = new List<Pardavejai>();
        Uzsakymas uzs = new Uzsakymas();
        bool arba = false;
        int knr;


        public Pardavimo_forma()
        {
            InitializeComponent();

            pard = SkaitytiPardevejus(pardavejuD);
            kli = SkaitytiPirkejus(klientuD);

            for (int i = 0; i < pard.Count; i++)
            {
                pardavejas.Items.Add(pard[i].ToString1());
            }

            for (int i = 0; i < kli.Count; i++)
            {
                pirkejas.Items.Add(kli[i].ToString1());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ieskotiP_Click(object sender, EventArgs e)
        {
            if(prekes.Count ==0)
                prekes = skaitytiProduktus(prekiuD);

            if (darzoves.Checked)
            {
                pasirinkti.Items.Clear();
                for (int i=0;i<prekes.Count; i++)
                {
                    if(prekes[i].tipas==1)
                    {
                        pasirinkti.Items.Add(prekes[i].ToString1());
                    }
                }
            }

            if(vaisiai.Checked)
            {
                pasirinkti.Items.Clear();
                for (int i = 0; i < prekes.Count; i++)
                {
                    if (prekes[i].tipas == 2)
                    {
                        pasirinkti.Items.Add(prekes[i].ToString1());
                    }
                }
            }

            if (gerimai.Checked)
            {
                pasirinkti.Items.Clear();
                for (int i = 0; i < prekes.Count; i++)
                {
                    if (prekes[i].tipas == 3)
                    {
                        pasirinkti.Items.Add(prekes[i].ToString1());
                    }
                }
            }

            if (pienoP.Checked)
            {
                pasirinkti.Items.Clear();
                for (int i = 0; i < prekes.Count; i++)
                {
                    if (prekes[i].tipas == 4)
                    {
                        pasirinkti.Items.Add(prekes[i].ToString1());
                    }
                }
            }

            if (riesutai.Checked)
            {
                pasirinkti.Items.Clear();
                for (int i = 0; i < prekes.Count; i++)
                {
                    if (prekes[i].tipas == 5)
                    {
                        pasirinkti.Items.Add(prekes[i].ToString1());
                    }
                }
            }

            if (gerimai.Checked)
            {
                pasirinkti.Items.Clear();
                for (int i = 0; i < prekes.Count; i++)
                {
                    if (prekes[i].tipas == 6)
                    {
                        pasirinkti.Items.Add(prekes[i].ToString1());
                    }
                }
            }

            
        }

        private void Pardavimo_forma_Load(object sender, EventArgs e)
        {
            
 
        }

        static List<produktaiclass> skaitytiProduktus(string pd)
        {
            List < produktaiclass> prekes = new List<produktaiclass>();


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
                    produktaiclass laik = new produktaiclass( tipas, pavadinimas, kaina);
                    prekes.Add(laik);
                }
                return prekes;
            }
        }

        private void prideti_Click(object sender, EventArgs e)
        {
            if (arba == false)
            {
                uzsakymoRez.ColumnCount = 5;
                uzsakymoRez.Columns[0].Name = "Pavadinimas";
                uzsakymoRez.Columns[0].Width = 200;
                uzsakymoRez.Columns[1].Name = "Tipas";
                uzsakymoRez.Columns[1].Width = 50;
                uzsakymoRez.Columns[2].Name = "Kaina";
                uzsakymoRez.Columns[2].Width = 50;
                uzsakymoRez.Columns[3].Name = "Kiekis";
                uzsakymoRez.Columns[3].Width = 50;
                uzsakymoRez.Columns[4].Name = "Suma";
                uzsakymoRez.Columns[4].Width = 50;
                arba = true;
            }
            string ivertis = pasirinkti.SelectedItem.ToString().TrimStart();
            string[] eilDalis = ivertis.Split(',');
            string pav = eilDalis[0];
            int kiek = Convert.ToInt32( Kiekis.Text);
            
            for (int i = 0; i < prekes.Count; i++)
                
            {
                if(pav==prekes[i].pavadinimas)
                {
                    uzsakymoRez.Rows.Add(prekes[i].pavadinimas,
                                        prekes[i].tipas,
                                        prekes[i].kaina,
                                        kiek,
                                        prekes[i].kaina * kiek);
                     prekes[i].kiekis = kiek;
                    //prekes2[j].pavadinimas = prekes[i].pavadinimas;
                    //prekes2[j].tipas = prekes[i].tipas;
                    //prekes2[j].kaina = prekes[i].kaina;
                    // prekes2[j].kiekis = kiek;
                    prekes2.Add(prekes[i]);
                        uzs.suma += prekes[i].kaina * kiek;

                }
            }
        }

        private void patvirtintiUzs_Click(object sender, EventArgs e)
        {

            string[] laik = pardavejas.Text.Split(',');
            string vard = laik[0];
            int IDp = int.Parse(laik[1]);
            

            for (int i = 0; i < pard.Count; i++)
            {
                if (IDp == pard[i].ID)
                {
                    uzs.pardavejoID = IDp;
                    uzs.uzsData = dateTimePicker1.Value.ToString("yyyy-MM-dd"); ;
                }
            }

            string[] laik1 = pirkejas.Text.Split(',');
            string vard1 = laik1[0];
            int IDk = int.Parse(laik1[1]);

            for (int i = 0; i < kli.Count; i++)
            {
                if (IDk == kli[i].ID)
                {
                    uzs.uzsakovas = IDk;
                    knr = i;
                }
            }

            //for (int j = 0; j < uzsakymoRez.Rows.Count; j++) 
            //{

            //    //string[] eilute = uzsakymoRez.Rows[j].ToString().Split('|');
            //    //prekes2[j].pavadinimas = eilute[0];
            //    //prekes2[j].tipas = int.Parse(eilute[1]);
            //    //prekes2[j].kaina = double.Parse(eilute[2]);
            //    //prekes2[j].kiekis = int.Parse(eilute[3]);
            //    //uzs.suma += double.Parse(eilute[4]);

            //    //string[] eilute = uzsakymoRez.Rows[j].ToString().Split('|');
            //    //string pavadinimas = eilute[0];
            //    //int tipas = int.Parse(eilute[1]);
            //    //double kaina = double.Parse(eilute[2]);
            //    //int kiekis = int.Parse(eilute[3]);
            //    //uzs.suma += double.Parse(eilute[4]);
                
            //    MessageBox.Show(uzsakymoRez.Rows[j].ToString());
            //}

            for (int i = 0; i < prekes2.Count; i++) 
            {

                produktaiclass pre = new produktaiclass(prekes2[i].tipas, prekes2[i].pavadinimas, prekes2[i].kaina, prekes2[i].kiekis);
                uzs.Deti(pre);
            }
            kli[knr].Deti(uzs);

            isvedimas(kliRez, kli[knr]);

            this.Close();
            //Pardavimo_forma pf = new Pardavimo_forma();
            //pf.Close();
        }


        static List<Pardavejai> SkaitytiPardevejus(string pd)
        {
        List<Pardavejai> pardavejai = new List<Pardavejai>();


                    using (StreamReader srautas = new StreamReader(pd, Encoding.GetEncoding(1257)))
                    {
                        string eilute;
                        int ID;
                        string vardas, pavarde,adresas;
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

        private void pasalinti_Click(object sender, EventArgs e)
        {
            if (this.uzsakymoRez.SelectedRows.Count > 0)
            {
                uzsakymoRez.Rows.RemoveAt(this.uzsakymoRez.SelectedRows[0].Index);

                ////for (int i = uzsakymoRez.SelectedRows[0].Index; i < prekes2.Count; i++)
                ////    prekes2[i] = prekes2[i + 1];
                //int j = this.uzsakymoRez.SelectedRows[0].Index;
                //prekes2.RemoveAt(j);
                //    //[uzsakymoRez.SelectedRows[0].Index];
            }

        }
        static void isvedimas(string rez, Klientai klientas)
        {

            using (var fr = new StreamWriter(File.Open(rez, FileMode.Append), Encoding.GetEncoding(1257)))
            {
                    fr.WriteLine(klientas.ToString());
                        fr.Write("  ");
                        fr.WriteLine(klientas.Imti(0).ToString());
                        for (int l = 0; l < klientas.Imti(0).plenght(); l++)
                        {
                            fr.Write("      ");
                            fr.WriteLine(klientas.Imti(0).Imti(l).ToString());
                        }
                        fr.WriteLine();
                    fr.WriteLine();
            }
        }
    }
}
