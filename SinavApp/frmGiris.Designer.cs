namespace SinavApp
{
    partial class frmGiris
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnSinavSec = new System.Windows.Forms.Button();
            this.lblSinavDosyaYolu = new System.Windows.Forms.Label();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(92, 20);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 3;

#if DEBUG
            this.txtAdSoyad.Text = "Orhan Aygün";
#endif
            // 
            // btnSinavSec
            // 
            this.btnSinavSec.Location = new System.Drawing.Point(24, 56);
            this.btnSinavSec.Name = "btnSinavSec";
            this.btnSinavSec.Size = new System.Drawing.Size(75, 23);
            this.btnSinavSec.TabIndex = 4;
            this.btnSinavSec.Text = "Sınav Seç";
            this.btnSinavSec.UseVisualStyleBackColor = true;
            this.btnSinavSec.Click += new System.EventHandler(this.btnSinavSec_Click);
            // 
            // lblSinavDosyaYolu
            // 
            this.lblSinavDosyaYolu.AutoSize = true;
            this.lblSinavDosyaYolu.Location = new System.Drawing.Point(130, 66);
            this.lblSinavDosyaYolu.Name = "lblSinavDosyaYolu";
            this.lblSinavDosyaYolu.Size = new System.Drawing.Size(289, 13);
            this.lblSinavDosyaYolu.TabIndex = 5;
#if DEBUG
            this.lblSinavDosyaYolu.Text = "C:\\codebase\\Bem.WinForms\\SinavApp\\Sinavlar\\sinav1.txt";
#endif
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(22, 101);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(170, 23);
            this.btnDevamEt.TabIndex = 6;
            this.btnDevamEt.Text = "DEVAM >>";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 156);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.lblSinavDosyaYolu);
            this.Controls.Add(this.btnSinavSec);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnSinavSec;
        public System.Windows.Forms.Label lblSinavDosyaYolu;
        private System.Windows.Forms.Button btnDevamEt;
    }
}

