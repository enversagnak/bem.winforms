using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public partial class frmSinavEkrani : Form
    {
        private object labelDogruSayiSonuc;
        private object labelYanlisSayiSonuc;
        private object dogru;
        private object yanlis;
        private object buttonTestBitir;
        private static object buttonTestBaslat;

        public string AdSoyad { get; set; }
        public string SinavDosyaYolu { get; set; }
        public TimeSpan SinavSüresi { get; private set; }
        public double SinavSüresiYüzdeOn { get; private set; }

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) : this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }

        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                SinavSüresi = TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()));
                SinavSüresiYüzdeOn = SinavSüresi.TotalSeconds * 0.1;

                string line = "";

                int soruSayisi = 0;
                int top = -350;
                int left = 0;

                while (!string.IsNullOrWhiteSpace((line = streamReader.ReadLine())))
                {
                    soruSayisi++;
                    var items = line.Split('|');

                    top += (soruSayisi % 2 == 1) ? 350 : 0;
                    left = (soruSayisi % 2 == 1) ? 0 : 286;

                    var groupBox = new GroupBox
                    {
                        Location = new Point(left, top),
                        Size = new Size(275, 300),
                        Text = $"{soruSayisi}. Soru"
                    };


                    int rbY = 30;

                    for (int i = 1; i <= items.Length -2; i++)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Text = items[i];
                        rb.Location = new Point(10, rbY);
                        rbY += 20;
                        groupBox.Controls.Add(rb);
                    }

                    var lbl = new Label
                    {
                        Text = items[0],
                        MaximumSize = new Size(260, 0),
                        AutoSize = true,
                        Location = new Point(15, 15)
                    };

                    groupBox.Controls.Add(lbl);

                    pnlSorular.Controls.Add(groupBox);

                };


                //timer1.Interval = 1;
            }
            private void Form1_Load(object sender, EventArgs e)
            {
            }

            private void button1_Click(object sender, EventArgs e)
            { //http://www.programlamadersleri.com
                FormAdSoyad frm2 = new FormAdSoyad();// Form 2ye ulaşmak için yeni nesne oluşturuyoruz 
                frm2.Show();//Form 2'yi ekrana çıkartıyoruz.
                this.Hide();//Bulunduğumuz formu gizliyoruz.

                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SinavSüresi.TotalSeconds == 0)
            {
                timer1.Stop();
            }
            this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");

            if (SinavSüresi.TotalSeconds <= SinavSüresiYüzdeOn)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }

            SinavSüresi = TimeSpan.FromSeconds(SinavSüresi.TotalSeconds - 1);

            if (SinavSüresi == 0)
            {
                timer1.Enabled = true;//Timerı çalıştırıyoruz.
                grupTrue();//GroupBox'ları aktifleştiriyoruz
                labelTCNoSonuc2.Text = textBoxTCNo.Text; ;//Tc kimlik numarasını labela yazıdırıyoruz.
                labelAdSoyadSonuc2.Text = textBoxAdSoyad.Text;//Ad ve soyadı labela yazdırıyoruz.
                buttonTestBaslat.Enabled = false;//Testi başlat butonunu pasifleştiriyoruz.
            }

        }
            if (SinavSüresi == 0)
                NewMethod1();
        }

        private static void NewMethod1()
        {
            NewMethod2();
            GrupFalse();//Bütün groupBox'ları false ediyoruz.
            MessageBox.Show("Süreniz dolmuştur");
            NewMethod3();
            NewMethod4();
            NewMethod5();
            NewMethod6();
            NewMethod7();
            NewMethod8();

           private  void pnlSorular_Paint(object sender, PaintEventArgs e)
            {

            }
            private void sonuclar(RadioButton seciliolan)
            {
                if (seciliolan.Checked == true)
                {//Eğer metoda gönderilmiş olan radiobuttun işaretlenmiş ise
                    NewMethod1();//Doğru sayısını arttır
                    seciliolan.BackColor = Color.Green;//Arkaplanını yeşil yap
                }//http://www.programlamadersleri.com
                else
                {//Seçili olan radiobuttun yanlış ise
                    NewMethod2();
                }
                labelDogruSayiSonuc = dogru.ToString();
                //Doğru sonuç sayısını yazdırıyoruz.
                labelYanlisSayiSonuc = yanlis.ToString();
                //Yanlış sonuç sayısını yazdırıyoruz.

            }

            private void NewMethod2()
            {
                NewMethod();//Yanlış sayısını arttır
            }

            private object NewMethod1()
            {
                return dogru++;
            }

            private object NewMethod()
            {
                return yanlis++;
            }

            public void grupFalse()
            {//Var olan groupbox'ları tek bir kod ile kapatmak için method oluşturuyoruz.
             //GroupBox içinde var olanları kullanılamaz hale getiriyoruz.
                groupBox.Enabled = false;
                groupBox.Enabled = false;
                groupBox.Enabled = false;
                groupBox.Enabled = false;
            }//http://www.programlamadersleri.com
            public void grupTrue()
            {//Var olan groupbox'ları tek bir kod ile açmak için method oluşturuyoruz.
             //GroupBox içinde var olanları yeniden kullanılabilir hale getiriyoruz.
                groupBox.Enabled = true;
                groupBox.Enabled = true;
                groupBox.Enabled = true;
                groupBox.Enabled = true;
            }
            private void groupBox1_Enter(object sender, EventArgs e)
            {
            }

            private void label1_Click(object sender, EventArgs e)
            {
            }

            private void FormAdSoyad_Load(object sender, EventArgs e)
            {//Form ilk açıldığından Groupboxları false yapıyoruz.
                grupFalse();
            }
            //http://www.programlamadersleri.com
            private void buttonTestBitir_Click(object sender, EventArgs e)
            {//Testi bitir butonuna tıkladığımızda;
                grupFalse();//Groupboxları false yapıyoruz.
                NewMethod();
                timer1.Enabled = false;//Timer'ı kapatıyoruz.
                                       //http://www.programlamadersleri.com
                                       //Soruların doğru cevaplarını sonuclar metoduna gönderiyoruz.
                sonuclar(radioButton4);
                sonuclar(radioButton5);
                sonuclar(radioButton11);
                Sonuclar(radioButton16);
            }
        }

        private static void NewMethod8()
        {
            Sonuclar(radioButton16);
        }

        private static void NewMethod7()
        {
            Sonuclar(radioButton11);
        }

        private static void NewMethod6()
        {
            Sonuclar(radioButton5);
        }

        private static void NewMethod5()
        {
            //http://www.programlamadersleri.com
            //Soruların doğru cevaplarını sonuclar metoduna gönderiyoruz.
            Sonuclar(radioButton4);
        }

        private static void Sonuclar(radioButton4 radioButton4)
        {
            throw new NotImplementedException();
        }

        private static void NewMethod4()
        {
            GetButtonTestBitir().Enabled = false;
        }

        private static void NewMethod3()
        {
            //Kullanıcıya Süresinin bittiğini belirlen bir uyarı veriyoruz.
            //Formda bulunan butonları pasifleştiriyoruz.
            buttonTestBaslat.Enabled = false;
        }

        private static object GetButtonTestBitir()
        {
            return buttonTestBitir;
        }

        private static void NewMethod2()
        {
            //Eğer sayac 0'a eşit ise yani verilen süre bitmiş ise
            System.Windows.Forms.Timer.Enabled = false;//Timerı durduruyoruz.
        }

        private static void GrupFalse()
        {
            throw new NotImplementedException();
        }

        private static void NewMethod()
        {
            buttonTestBitir.Enabled = false;//Testi bitir butonunu pasifleştiriyoruz
        }
    }
