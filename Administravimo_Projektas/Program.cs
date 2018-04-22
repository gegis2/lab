using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administravimo_Projektas
{
    class Program
    {
        const string kfailas = ("kfailas.txt");
        const string ufailas = ("ufailas.txt");
        const string pfailas = ("pfailas.txt");
        const string rez = ("rezultatai.txt");
        static void Main(string[] args)
        {
            Klientas[] klientoduomenys = new Klientas[50];
            klientoduomenys = SkaitytiDuomenys(kfailas, ufailas, pfailas);
            klientoduomenys = rykiuoti(klientoduomenys);
            isvedimas(rez, klientoduomenys);
        }
        static Klientas[] SkaitytiDuomenys(string fvk ,string fvu, string fvp)
        {
            Klientas[] klientas = new Klientas[100];
            using (StreamReader srautas = new StreamReader(fvk, Encoding.GetEncoding(1257)))
            {
                string eilute;
                string line;
                int ID;
                string vardas, pavarde, miestas, tel, el_pastas;
                line = srautas.ReadLine();
                int i = 0;
                while ((eilute = srautas.ReadLine()) != null )
                {
                    string[] eilDalis = eilute.Split(';');

                    ID = int.Parse(eilDalis[0]);
                    vardas = eilDalis[1];
                    pavarde = eilDalis[2];
                    miestas = eilDalis[3];
                    tel = eilDalis[4];
                    el_pastas = eilDalis[6];
                    klientas[i] = new Klientas(ID, vardas, pavarde, miestas, tel, el_pastas);
                    i++;
                }
            }

            using (StreamReader srautas = new StreamReader(fvu, Encoding.GetEncoding(1257)))
            {
                string eilute;
                string line;
                int ID, klientoID;
                DateTime uzsakymoData;
                line = srautas.ReadLine();

                while ((eilute = srautas.ReadLine()) != null)
                {
                    string[] eilDalis = eilute.Split(';');
                    ID = int.Parse(eilDalis[0]);
                    uzsakymoData = DateTime.Parse(eilDalis[1]);
                    klientoID = int.Parse(eilDalis[2]);
                    Uzsakymas uzs = new Uzsakymas(ID, uzsakymoData );
                    for(int i=0;i < klientas.Length;i++)
                    {
                        if (klientas[i].ID == klientoID)
                        {
                            klientas[i].Deti(uzs);
                        }
                        if(i == klientas.Length)
                        {
                            Console.WriteLine("uzsakymas be kliento egistuot negali, klaidingas ID ");
                        }
                    }
                }
            }

                    using (StreamReader srautas = new StreamReader(fvp, Encoding.GetEncoding(1257)))
            {
                string eilute;
                string line;
                int ID, kiekis, uzsakymoID;
                string pavadinimas;
                double kaina;
                line = srautas.ReadLine();

                while ((eilute = srautas.ReadLine()) != null)
                {
                    string[] eilDalis = eilute.Split(';');
                    ID = int.Parse(eilDalis[0]);
                    pavadinimas = eilDalis[1];
                    kaina = double.Parse(eilDalis[2]);
                    kiekis = int.Parse(eilDalis[3]);
                    uzsakymoID = int.Parse(eilDalis[4]);
                    Preke prek = new Preke(ID, pavadinimas, kaina, kiekis);
                    for(int i =0; i<klientas.Length;i++)
                    {
                        for(int j= 0; j<klientas[i].ulenght(); j++)
                        {
                            if(klientas[i].Imti(j).ID==uzsakymoID)
                            {
                                klientas[i].Imti(j).Deti(prek);
                            }
                        }
                        if (i == klientas.Length)
                        {
                            Console.WriteLine("prekes privalo priklausyti jau egzistuojanciam uzsakymui ");
                        }
                    }


                }
            }


                return klientas;
        }

        static Klientas[] rykiuoti(Klientas[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (items[j - 1] > items[j])
                    {
                        items.Swap(j, items[j], items[j - 1]);
                    }
                }
            }
        }

        static void isvedimas(string rez, Klientas[] klientas)
        {

            using (var fr = new StreamWriter(File.Open(rez, FileMode.Append), Encoding.GetEncoding(1257)))
            {
                for(int i=0; i<klientas.Length;i++)
                {
                    fr.WriteLine(klientas[i].ToString());
                    for(int j = 0; j < klientas[i].ulenght();j++)
                    {
                        fr.WriteLine(klientas[i].Imti(j).ToString());
                        for (int l = 0; l < klientas[i].Imti(j).plenght(); l++) 
                        {
                            fr.WriteLine(klientas[i].Imti(j).ToString());
                        }
                        fr.WriteLine();
                    }
                    fr.WriteLine();
                }
            }
        }
    }
}
