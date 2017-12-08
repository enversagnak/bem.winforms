namespace SinavApp
{
    partial class frmSinavEkrani
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
            this.lblSinavAdi = new System.Windows.Forms.Label();
            this.lblSinavAciklama = new System.Windows.Forms.Label();
            this.prgCevapOrani = new System.Windows.Forms.ProgressBar();
            this.pnlSorular = new SinavApp.CustomPanel();
            this.lblKalanZaman = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSinavAdi
            // 
            this.lblSinavAdi.AutoSize = true;
            this.lblSinavAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavAdi.Location = new System.Drawing.Point(13, 13);
            this.lblSinavAdi.Name = "lblSinavAdi";
            this.lblSinavAdi.Size = new System.Drawing.Size(112, 25);
            this.lblSinavAdi.TabIndex = 0;
            this.lblSinavAdi.Text = "Sınav Adı";
            // 
            // lblSinavAciklama
            // 
            this.lblSinavAciklama.AutoSize = true;
            this.lblSinavAciklama.Location = new System.Drawing.Point(15, 61);
            this.lblSinavAciklama.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblSinavAciklama.Name = "lblSinavAciklama";
            this.lblSinavAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblSinavAciklama.TabIndex = 1;
            this.lblSinavAciklama.Text = "Açıklama";
            // 
            // prgCevapOrani
            // 
            this.prgCevapOrani.Location = new System.Drawing.Point(12, 175);
            this.prgCevapOrani.Name = "prgCevapOrani";
            this.prgCevapOrani.Size = new System.Drawing.Size(561, 23);
            this.prgCevapOrani.TabIndex = 2;
            // 
            // pnlSorular
            // 
            this.pnlSorular.AutoScroll = true;
            this.pnlSorular.Location = new System.Drawing.Point(12, 204);
            this.pnlSorular.Name = "pnlSorular";
            this.pnlSorular.Size = new System.Drawing.Size(561, 241);
            this.pnlSorular.TabIndex = 3;
            this.pnlSorular.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSorular_Paint);
            // 
            // lblKalanZaman
            // 
            this.lblKalanZaman.AutoSize = true;
            this.lblKalanZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanZaman.ForeColor = System.Drawing.Color.Green;
            this.lblKalanZaman.Location = new System.Drawing.Point(486, 13);
            this.lblKalanZaman.Name = "lblKalanZaman";
            this.lblKalanZaman.Size = new System.Drawing.Size(87, 31);
            this.lblKalanZaman.TabIndex = 4;
            this.lblKalanZaman.Text = "00:00";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(520, 61);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "Ad Soyad";
            this.lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSinavEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 457);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblKalanZaman);
            this.Controls.Add(this.pnlSorular);
            this.Controls.Add(this.prgCevapOrani);
            this.Controls.Add(this.lblSinavAciklama);
            this.Controls.Add(this.lblSinavAdi);
            this.Name = "frmSinavEkrani";
            this.Text = "frmSinavEkrani";
            this.Load += new System.EventHandler(this.frmSinavEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinavAdi;
        private System.Windows.Forms.Label lblSinavAciklama;
        private System.Windows.Forms.ProgressBar prgCevapOrani;
        private System.Windows.Forms.Panel pnlSorular;
        private System.Windows.Forms.Label lblKalanZaman;
        public System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Timer timer1;

    }
}