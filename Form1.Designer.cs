namespace trackBarKontrolaDinoK
{
    partial class TrackBar
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
            this.trkVrijednost = new System.Windows.Forms.TrackBar();
            this.txtVrijednost = new System.Windows.Forms.TextBox();
            this.lblVrijednost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkVrijednost)).BeginInit();
            this.SuspendLayout();
            // 
            // trkVrijednost
            // 
            this.trkVrijednost.Location = new System.Drawing.Point(188, 81);
            this.trkVrijednost.Maximum = 100;
            this.trkVrijednost.Name = "trkVrijednost";
            this.trkVrijednost.Size = new System.Drawing.Size(357, 45);
            this.trkVrijednost.TabIndex = 0;
            this.trkVrijednost.Scroll += new System.EventHandler(this.trkVrijednost_Scroll);
            // 
            // txtVrijednost
            // 
            this.txtVrijednost.Location = new System.Drawing.Point(355, 161);
            this.txtVrijednost.Name = "txtVrijednost";
            this.txtVrijednost.Size = new System.Drawing.Size(100, 20);
            this.txtVrijednost.TabIndex = 1;
            this.txtVrijednost.TextChanged += new System.EventHandler(this.txtVrijednost_TextChanged);
            // 
            // lblVrijednost
            // 
            this.lblVrijednost.AutoSize = true;
            this.lblVrijednost.Location = new System.Drawing.Point(219, 164);
            this.lblVrijednost.Name = "lblVrijednost";
            this.lblVrijednost.Size = new System.Drawing.Size(130, 13);
            this.lblVrijednost.TabIndex = 2;
            this.lblVrijednost.Text = "Postavljena vrijednost je : ";
            this.lblVrijednost.Click += new System.EventHandler(this.label1_Click);
            // 
            // TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVrijednost);
            this.Controls.Add(this.txtVrijednost);
            this.Controls.Add(this.trkVrijednost);
            this.Name = "TrackBar";
            this.Text = "TrackBar";
            ((System.ComponentModel.ISupportInitialize)(this.trkVrijednost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkVrijednost;
        private System.Windows.Forms.TextBox txtVrijednost;
        private System.Windows.Forms.Label lblVrijednost;
    }
}

