namespace ProjektoGUI
{
    partial class Pardavimo_forma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pardavejas = new System.Windows.Forms.ComboBox();
            this.pasirinkitPard = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.MaskedTextBox();
            this.vardas = new System.Windows.Forms.MaskedTextBox();
            this.pavarde = new System.Windows.Forms.MaskedTextBox();
            this.adresas = new System.Windows.Forms.MaskedTextBox();
            this.patvirtintiUzs = new System.Windows.Forms.Button();
            this.ieskotiP = new System.Windows.Forms.Button();
            this.uzsakymoRez = new System.Windows.Forms.DataGridView();
            this.prideti = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.koditerija = new System.Windows.Forms.CheckBox();
            this.riesutai = new System.Windows.Forms.CheckBox();
            this.pienoP = new System.Windows.Forms.CheckBox();
            this.gerimai = new System.Windows.Forms.CheckBox();
            this.vaisiai = new System.Windows.Forms.CheckBox();
            this.darzoves = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Kiekis = new System.Windows.Forms.TextBox();
            this.pasirinkti = new System.Windows.Forms.ComboBox();
            this.uzkrauti = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.produktaiclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uzsakymasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymoRez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktaiclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzsakymo formavimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pirkejas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vardas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pavarde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pardavejas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pasirinkite pardaveja:";
            // 
            // pardavejas
            // 
            this.pardavejas.FormattingEnabled = true;
            this.pardavejas.Location = new System.Drawing.Point(521, 130);
            this.pardavejas.Margin = new System.Windows.Forms.Padding(4);
            this.pardavejas.Name = "pardavejas";
            this.pardavejas.Size = new System.Drawing.Size(160, 24);
            this.pardavejas.TabIndex = 8;
            this.pardavejas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pasirinkitPard
            // 
            this.pasirinkitPard.Location = new System.Drawing.Point(845, 126);
            this.pasirinkitPard.Margin = new System.Windows.Forms.Padding(4);
            this.pasirinkitPard.Name = "pasirinkitPard";
            this.pasirinkitPard.Size = new System.Drawing.Size(100, 28);
            this.pasirinkitPard.TabIndex = 9;
            this.pasirinkitPard.Text = "Pasirinkta";
            this.pasirinkitPard.UseVisualStyleBackColor = true;
            this.pasirinkitPard.Click += new System.EventHandler(this.pasirinkitPard_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Preke";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 99);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Suformavimo data:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(129, 210);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(132, 22);
            this.ID.TabIndex = 17;
            // 
            // vardas
            // 
            this.vardas.Location = new System.Drawing.Point(129, 250);
            this.vardas.Margin = new System.Windows.Forms.Padding(4);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(132, 22);
            this.vardas.TabIndex = 18;
            // 
            // pavarde
            // 
            this.pavarde.Location = new System.Drawing.Point(129, 292);
            this.pavarde.Margin = new System.Windows.Forms.Padding(4);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(132, 22);
            this.pavarde.TabIndex = 19;
            // 
            // adresas
            // 
            this.adresas.Location = new System.Drawing.Point(129, 333);
            this.adresas.Margin = new System.Windows.Forms.Padding(4);
            this.adresas.Name = "adresas";
            this.adresas.Size = new System.Drawing.Size(132, 22);
            this.adresas.TabIndex = 20;
            // 
            // patvirtintiUzs
            // 
            this.patvirtintiUzs.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.patvirtintiUzs.Location = new System.Drawing.Point(865, 545);
            this.patvirtintiUzs.Margin = new System.Windows.Forms.Padding(4);
            this.patvirtintiUzs.Name = "patvirtintiUzs";
            this.patvirtintiUzs.Size = new System.Drawing.Size(100, 28);
            this.patvirtintiUzs.TabIndex = 24;
            this.patvirtintiUzs.Text = "Patvirtinta";
            this.patvirtintiUzs.UseVisualStyleBackColor = false;
            this.patvirtintiUzs.Click += new System.EventHandler(this.patvirtintiUzs_Click);
            // 
            // ieskotiP
            // 
            this.ieskotiP.Location = new System.Drawing.Point(747, 206);
            this.ieskotiP.Margin = new System.Windows.Forms.Padding(4);
            this.ieskotiP.Name = "ieskotiP";
            this.ieskotiP.Size = new System.Drawing.Size(100, 28);
            this.ieskotiP.TabIndex = 25;
            this.ieskotiP.Text = "Ieskoti";
            this.ieskotiP.UseVisualStyleBackColor = true;
            this.ieskotiP.Click += new System.EventHandler(this.ieskotiP_Click);
            // 
            // uzsakymoRez
            // 
            this.uzsakymoRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uzsakymoRez.Location = new System.Drawing.Point(47, 423);
            this.uzsakymoRez.Name = "uzsakymoRez";
            this.uzsakymoRez.RowTemplate.Height = 24;
            this.uzsakymoRez.Size = new System.Drawing.Size(800, 150);
            this.uzsakymoRez.TabIndex = 33;
            // 
            // prideti
            // 
            this.prideti.Location = new System.Drawing.Point(832, 350);
            this.prideti.Name = "prideti";
            this.prideti.Size = new System.Drawing.Size(75, 23);
            this.prideti.TabIndex = 41;
            this.prideti.Text = "Prideti";
            this.prideti.UseVisualStyleBackColor = true;
            this.prideti.Click += new System.EventHandler(this.prideti_Click);
            // 
            // koditerija
            // 
            this.koditerija.AutoSize = true;
            this.koditerija.Location = new System.Drawing.Point(557, 265);
            this.koditerija.Margin = new System.Windows.Forms.Padding(4);
            this.koditerija.Name = "koditerija";
            this.koditerija.Size = new System.Drawing.Size(113, 21);
            this.koditerija.TabIndex = 51;
            this.koditerija.Text = "konditerija(6)";
            this.koditerija.UseVisualStyleBackColor = true;
            // 
            // riesutai
            // 
            this.riesutai.AutoSize = true;
            this.riesutai.Location = new System.Drawing.Point(453, 265);
            this.riesutai.Margin = new System.Windows.Forms.Padding(4);
            this.riesutai.Name = "riesutai";
            this.riesutai.Size = new System.Drawing.Size(94, 21);
            this.riesutai.TabIndex = 50;
            this.riesutai.Text = "riesutai(5)";
            this.riesutai.UseVisualStyleBackColor = true;
            // 
            // pienoP
            // 
            this.pienoP.AutoSize = true;
            this.pienoP.Location = new System.Drawing.Point(313, 265);
            this.pienoP.Margin = new System.Windows.Forms.Padding(4);
            this.pienoP.Name = "pienoP";
            this.pienoP.Size = new System.Drawing.Size(146, 21);
            this.pienoP.TabIndex = 49;
            this.pienoP.Text = "pieno produktai(4)";
            this.pienoP.UseVisualStyleBackColor = true;
            // 
            // gerimai
            // 
            this.gerimai.AutoSize = true;
            this.gerimai.Location = new System.Drawing.Point(557, 219);
            this.gerimai.Margin = new System.Windows.Forms.Padding(4);
            this.gerimai.Name = "gerimai";
            this.gerimai.Size = new System.Drawing.Size(94, 21);
            this.gerimai.TabIndex = 48;
            this.gerimai.Text = "gerimai(3)";
            this.gerimai.UseVisualStyleBackColor = true;
            // 
            // vaisiai
            // 
            this.vaisiai.AutoSize = true;
            this.vaisiai.Location = new System.Drawing.Point(453, 219);
            this.vaisiai.Margin = new System.Windows.Forms.Padding(4);
            this.vaisiai.Name = "vaisiai";
            this.vaisiai.Size = new System.Drawing.Size(87, 21);
            this.vaisiai.TabIndex = 47;
            this.vaisiai.Text = "vaisiai(2)";
            this.vaisiai.UseVisualStyleBackColor = true;
            // 
            // darzoves
            // 
            this.darzoves.AutoSize = true;
            this.darzoves.Location = new System.Drawing.Point(314, 219);
            this.darzoves.Margin = new System.Windows.Forms.Padding(4);
            this.darzoves.Name = "darzoves";
            this.darzoves.Size = new System.Drawing.Size(106, 21);
            this.darzoves.TabIndex = 46;
            this.darzoves.Text = "darzoves(1)";
            this.darzoves.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(708, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Produktai";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(719, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Kiekis";
            // 
            // Kiekis
            // 
            this.Kiekis.Location = new System.Drawing.Point(474, 387);
            this.Kiekis.Name = "Kiekis";
            this.Kiekis.Size = new System.Drawing.Size(161, 22);
            this.Kiekis.TabIndex = 43;
            this.Kiekis.UseWaitCursor = true;
            // 
            // pasirinkti
            // 
            this.pasirinkti.FormattingEnabled = true;
            this.pasirinkti.Location = new System.Drawing.Point(472, 346);
            this.pasirinkti.Name = "pasirinkti";
            this.pasirinkti.Size = new System.Drawing.Size(161, 24);
            this.pasirinkti.TabIndex = 42;
            // 
            // uzkrauti
            // 
            this.uzkrauti.Location = new System.Drawing.Point(701, 126);
            this.uzkrauti.Name = "uzkrauti";
            this.uzkrauti.Size = new System.Drawing.Size(99, 26);
            this.uzkrauti.TabIndex = 53;
            this.uzkrauti.Text = "Uzkrauti";
            this.uzkrauti.UseVisualStyleBackColor = true;
            this.uzkrauti.Click += new System.EventHandler(this.uzkrauti_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(351, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Galima rinktis tik po viena ketegorija";
            // 
            // produktaiclassBindingSource
            // 
            this.produktaiclassBindingSource.DataSource = typeof(ProjektoGUI.produktaiclass);
            // 
            // uzsakymasBindingSource
            // 
            this.uzsakymasBindingSource.DataSource = typeof(ProjektoGUI.Uzsakymas);
            // 
            // klientaiBindingSource
            // 
            this.klientaiBindingSource.DataSource = typeof(ProjektoGUI.Klientai);
            // 
            // Pardavimo_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 609);
            this.Controls.Add(this.uzkrauti);
            this.Controls.Add(this.prideti);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.koditerija);
            this.Controls.Add(this.riesutai);
            this.Controls.Add(this.pienoP);
            this.Controls.Add(this.gerimai);
            this.Controls.Add(this.vaisiai);
            this.Controls.Add(this.darzoves);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Kiekis);
            this.Controls.Add(this.pasirinkti);
            this.Controls.Add(this.uzsakymoRez);
            this.Controls.Add(this.ieskotiP);
            this.Controls.Add(this.patvirtintiUzs);
            this.Controls.Add(this.adresas);
            this.Controls.Add(this.pavarde);
            this.Controls.Add(this.vardas);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pasirinkitPard);
            this.Controls.Add(this.pardavejas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pardavimo_forma";
            this.Text = "Uzsakymo forma";
            this.Load += new System.EventHandler(this.Pardavimo_forma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymoRez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktaiclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox pardavejas;
        private System.Windows.Forms.Button pasirinkitPard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox ID;
        private System.Windows.Forms.MaskedTextBox vardas;
        private System.Windows.Forms.MaskedTextBox pavarde;
        private System.Windows.Forms.MaskedTextBox adresas;
        private System.Windows.Forms.Button patvirtintiUzs;
        private System.Windows.Forms.Button ieskotiP;
        private System.Windows.Forms.DataGridView uzsakymoRez;
        private System.Windows.Forms.Button prideti;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox koditerija;
        private System.Windows.Forms.CheckBox riesutai;
        private System.Windows.Forms.CheckBox pienoP;
        private System.Windows.Forms.CheckBox gerimai;
        private System.Windows.Forms.CheckBox vaisiai;
        private System.Windows.Forms.CheckBox darzoves;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Kiekis;
        private System.Windows.Forms.ComboBox pasirinkti;
        private System.Windows.Forms.BindingSource uzsakymasBindingSource;
        private System.Windows.Forms.BindingSource klientaiBindingSource;
        private System.Windows.Forms.Button uzkrauti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource produktaiclassBindingSource;
    }
}