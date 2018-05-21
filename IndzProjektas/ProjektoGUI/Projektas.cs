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
    public partial class Projektas : Form
    {
        

        public Projektas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Pardavimo_forma formavimas = new Pardavimo_forma();
            formavimas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paieska paieska = new Paieska();
            paieska.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Itraukimas itraukimas = new Itraukimas();
            itraukimas.Show();
        }

        private void apieMusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Komanda sudaro grupes IFIN 6/1 studentai \n Deividas Bigelis \n" +
                            " Laura Briedyte \n Mindaugas Navickas \n Martynas Dirmauskis \n Simas Guliokas");
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Katalogas katalogas = new Katalogas();
            katalogas.Show();

        }

        
    }
}
