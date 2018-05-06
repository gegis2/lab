namespace ProjektoGUI
{
    partial class Itraukimas
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
            this.label1 = new System.Windows.Forms.Label();
            this.adresas1 = new System.Windows.Forms.MaskedTextBox();
            this.paarde1 = new System.Windows.Forms.MaskedTextBox();
            this.vardas1 = new System.Windows.Forms.MaskedTextBox();
            this.ID1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Itraukimas";
            // 
            // adresas1
            // 
            this.adresas1.Location = new System.Drawing.Point(121, 260);
            this.adresas1.Margin = new System.Windows.Forms.Padding(4);
            this.adresas1.Name = "adresas1";
            this.adresas1.Size = new System.Drawing.Size(132, 22);
            this.adresas1.TabIndex = 28;
            // 
            // paarde1
            // 
            this.paarde1.Location = new System.Drawing.Point(121, 219);
            this.paarde1.Margin = new System.Windows.Forms.Padding(4);
            this.paarde1.Name = "paarde1";
            this.paarde1.Size = new System.Drawing.Size(132, 22);
            this.paarde1.TabIndex = 27;
            // 
            // vardas1
            // 
            this.vardas1.Location = new System.Drawing.Point(121, 177);
            this.vardas1.Margin = new System.Windows.Forms.Padding(4);
            this.vardas1.Name = "vardas1";
            this.vardas1.Size = new System.Drawing.Size(132, 22);
            this.vardas1.TabIndex = 26;
            // 
            // ID1
            // 
            this.ID1.Location = new System.Drawing.Point(121, 137);
            this.ID1.Margin = new System.Windows.Forms.Padding(4);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(132, 22);
            this.ID1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Adresas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pavarde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vardas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "patvirtiniti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Itraukimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adresas1);
            this.Controls.Add(this.paarde1);
            this.Controls.Add(this.vardas1);
            this.Controls.Add(this.ID1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Itraukimas";
            this.Text = "Itraukimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox adresas1;
        private System.Windows.Forms.MaskedTextBox paarde1;
        private System.Windows.Forms.MaskedTextBox vardas1;
        private System.Windows.Forms.MaskedTextBox ID1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}