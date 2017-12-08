namespace RichTextBox
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmenuStyle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.diğerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altçizgiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFontSec = new System.Windows.Forms.Button();
            this.btnSolaYasla = new System.Windows.Forms.Button();
            this.btnOrtala = new System.Windows.Forms.Button();
            this.btnSagaYasla = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.menuDosya = new System.Windows.Forms.MenuStrip();
            this.menuItemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAç = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.cmenuStyle.SuspendLayout();
            this.menuDosya.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.cmenuStyle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 402);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cmenuStyle
            // 
            this.cmenuStyle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.görünümToolStripMenuItem,
            this.boyutToolStripMenuItem,
            this.toolStripSeparator1,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.cmenuStyle.Name = "cmenuStyle";
            this.cmenuStyle.Size = new System.Drawing.Size(126, 142);
            this.cmenuStyle.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmenuStyle_Closed);
            this.cmenuStyle.Opened += new System.EventHandler(this.cmenuStyle_Opened);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kırmızıToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.toolStripSeparator2,
            this.diğerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Renk";
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(108, 6);
            // 
            // diğerToolStripMenuItem
            // 
            this.diğerToolStripMenuItem.Name = "diğerToolStripMenuItem";
            this.diğerToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.diğerToolStripMenuItem.Text = "Diğer...";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalınToolStripMenuItem,
            this.italikToolStripMenuItem,
            this.altçizgiliToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // kalınToolStripMenuItem
            // 
            this.kalınToolStripMenuItem.CheckOnClick = true;
            this.kalınToolStripMenuItem.Name = "kalınToolStripMenuItem";
            this.kalınToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kalınToolStripMenuItem.Text = "Kalın";
            this.kalınToolStripMenuItem.Click += new System.EventHandler(this.kalınToolStripMenuItem_Click);
            // 
            // italikToolStripMenuItem
            // 
            this.italikToolStripMenuItem.CheckOnClick = true;
            this.italikToolStripMenuItem.Name = "italikToolStripMenuItem";
            this.italikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.italikToolStripMenuItem.Text = "İtalik";
            this.italikToolStripMenuItem.Click += new System.EventHandler(this.italikToolStripMenuItem_Click);
            // 
            // altçizgiliToolStripMenuItem
            // 
            this.altçizgiliToolStripMenuItem.CheckOnClick = true;
            this.altçizgiliToolStripMenuItem.Name = "altçizgiliToolStripMenuItem";
            this.altçizgiliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altçizgiliToolStripMenuItem.Text = "Altçizgili";
            this.altçizgiliToolStripMenuItem.Click += new System.EventHandler(this.altçizgiliToolStripMenuItem_Click);
            // 
            // boyutToolStripMenuItem
            // 
            this.boyutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripTextBox1});
            this.boyutToolStripMenuItem.Name = "boyutToolStripMenuItem";
            this.boyutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boyutToolStripMenuItem.Text = "Boyut";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "8";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem3.Text = "10";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem4.Text = "12";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // btnFontSec
            // 
            this.btnFontSec.Location = new System.Drawing.Point(12, 45);
            this.btnFontSec.Name = "btnFontSec";
            this.btnFontSec.Size = new System.Drawing.Size(75, 23);
            this.btnFontSec.TabIndex = 1;
            this.btnFontSec.Text = "Font Seç";
            this.btnFontSec.UseVisualStyleBackColor = true;
            this.btnFontSec.Click += new System.EventHandler(this.btnFontSec_Click);
            // 
            // btnSolaYasla
            // 
            this.btnSolaYasla.Location = new System.Drawing.Point(123, 45);
            this.btnSolaYasla.Name = "btnSolaYasla";
            this.btnSolaYasla.Size = new System.Drawing.Size(75, 23);
            this.btnSolaYasla.TabIndex = 2;
            this.btnSolaYasla.Text = "Sola Yasla";
            this.btnSolaYasla.UseVisualStyleBackColor = true;
            this.btnSolaYasla.Click += new System.EventHandler(this.btnSolaYasla_Click);
            // 
            // btnOrtala
            // 
            this.btnOrtala.Location = new System.Drawing.Point(204, 45);
            this.btnOrtala.Name = "btnOrtala";
            this.btnOrtala.Size = new System.Drawing.Size(75, 23);
            this.btnOrtala.TabIndex = 3;
            this.btnOrtala.Text = "Ortala";
            this.btnOrtala.UseVisualStyleBackColor = true;
            this.btnOrtala.Click += new System.EventHandler(this.btnOrtala_Click);
            // 
            // btnSagaYasla
            // 
            this.btnSagaYasla.Location = new System.Drawing.Point(285, 45);
            this.btnSagaYasla.Name = "btnSagaYasla";
            this.btnSagaYasla.Size = new System.Drawing.Size(75, 23);
            this.btnSagaYasla.TabIndex = 4;
            this.btnSagaYasla.Text = "Sağa Yasla";
            this.btnSagaYasla.UseVisualStyleBackColor = true;
            this.btnSagaYasla.Click += new System.EventHandler(this.btnSagaYasla_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(398, 45);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnRenkDegistir.TabIndex = 5;
            this.btnRenkDegistir.Text = "Renk";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // menuDosya
            // 
            this.menuDosya.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemYeni,
            this.menuItemAç,
            this.kaydetToolStripMenuItem});
            this.menuDosya.Location = new System.Drawing.Point(0, 0);
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(781, 24);
            this.menuDosya.TabIndex = 6;
            this.menuDosya.Text = "Dosya";
            // 
            // menuItemYeni
            // 
            this.menuItemYeni.Name = "menuItemYeni";
            this.menuItemYeni.Size = new System.Drawing.Size(41, 20);
            this.menuItemYeni.Text = "Yeni";
            this.menuItemYeni.Click += new System.EventHandler(this.menuItemYeni_Click);
            // 
            // menuItemAç
            // 
            this.menuItemAç.Name = "menuItemAç";
            this.menuItemAç.Size = new System.Drawing.Size(33, 20);
            this.menuItemAç.Text = "Aç";
            this.menuItemAç.Click += new System.EventHandler(this.menuItemAç_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(501, 83);
            this.trackBar1.Maximum = 56;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 156);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar4);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Location = new System.Drawing.Point(501, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renk";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(20, 19);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(20, 66);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(20, 117);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 2;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.btnSagaYasla);
            this.Controls.Add(this.btnOrtala);
            this.Controls.Add(this.btnSolaYasla);
            this.Controls.Add(this.btnFontSec);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuDosya);
            this.MainMenuStrip = this.menuDosya;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmenuStyle.ResumeLayout(false);
            this.menuDosya.ResumeLayout(false);
            this.menuDosya.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFontSec;
        private System.Windows.Forms.Button btnSolaYasla;
        private System.Windows.Forms.Button btnOrtala;
        private System.Windows.Forms.Button btnSagaYasla;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.MenuStrip menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuItemYeni;
        private System.Windows.Forms.ToolStripMenuItem menuItemAç;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip cmenuStyle;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altçizgiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem diğerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

