namespace ProjektoGUI
{
    partial class Katalogas
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
            this.kataloguView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kataloguView)).BeginInit();
            this.SuspendLayout();
            // 
            // kataloguView
            // 
            this.kataloguView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kataloguView.Location = new System.Drawing.Point(35, 27);
            this.kataloguView.Name = "kataloguView";
            this.kataloguView.RowTemplate.Height = 24;
            this.kataloguView.Size = new System.Drawing.Size(410, 332);
            this.kataloguView.TabIndex = 0;
            // 
            // Katalogas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kataloguView);
            this.Name = "Katalogas";
            this.Text = "Katalogas";
            this.Load += new System.EventHandler(this.Katalogas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kataloguView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kataloguView;
    }
}