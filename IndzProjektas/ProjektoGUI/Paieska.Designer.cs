namespace ProjektoGUI
{
    partial class Paieska
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
            this.label2 = new System.Windows.Forms.Label();
            this.darbuotojas = new System.Windows.Forms.CheckBox();
            this.klientas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.MaskedTextBox();
            this.paieskosats = new System.Windows.Forms.RichTextBox();
            this.ieskoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paieska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ieskoti: ";
            // 
            // darbuotojas
            // 
            this.darbuotojas.AutoSize = true;
            this.darbuotojas.Location = new System.Drawing.Point(103, 94);
            this.darbuotojas.Margin = new System.Windows.Forms.Padding(4);
            this.darbuotojas.Name = "darbuotojas";
            this.darbuotojas.Size = new System.Drawing.Size(98, 21);
            this.darbuotojas.TabIndex = 5;
            this.darbuotojas.Text = "darbuotojo";
            this.darbuotojas.UseVisualStyleBackColor = true;
            // 
            // klientas
            // 
            this.klientas.AutoSize = true;
            this.klientas.Location = new System.Drawing.Point(212, 94);
            this.klientas.Margin = new System.Windows.Forms.Padding(4);
            this.klientas.Name = "klientas";
            this.klientas.Size = new System.Drawing.Size(71, 21);
            this.klientas.TabIndex = 6;
            this.klientas.Text = "kliento";
            this.klientas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID: ";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(71, 142);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(132, 22);
            this.ID.TabIndex = 8;
            // 
            // paieskosats
            // 
            this.paieskosats.Location = new System.Drawing.Point(71, 207);
            this.paieskosats.Name = "paieskosats";
            this.paieskosats.Size = new System.Drawing.Size(361, 203);
            this.paieskosats.TabIndex = 9;
            this.paieskosats.Text = "";
            // 
            // ieskoti
            // 
            this.ieskoti.Location = new System.Drawing.Point(280, 138);
            this.ieskoti.Name = "ieskoti";
            this.ieskoti.Size = new System.Drawing.Size(152, 34);
            this.ieskoti.TabIndex = 10;
            this.ieskoti.Text = "Ieskoti";
            this.ieskoti.UseVisualStyleBackColor = true;
            this.ieskoti.Click += new System.EventHandler(this.ieskoti_Click);
            // 
            // Paieska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 452);
            this.Controls.Add(this.ieskoti);
            this.Controls.Add(this.paieskosats);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.klientas);
            this.Controls.Add(this.darbuotojas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Paieska";
            this.Text = "Paieska";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox darbuotojas;
        private System.Windows.Forms.CheckBox klientas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ID;
        private System.Windows.Forms.RichTextBox paieskosats;
        private System.Windows.Forms.Button ieskoti;
    }
}