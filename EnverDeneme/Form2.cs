using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnverDeneme
{
    public partial class FormAdSoyad : Form
    {//http://www.programlamadersleri.com

        int sayac = 20;//Geriye doğru saydıracağımzı sayacımızı oluşturuyoruz.
        int dogru = 0, yanlis = 0;
        //Verilen şıklara göre arttıracağımız doğru ve 
        //yanlış için değişkenler oluşturuyoruz.
        //http://www.programlamadersleri.com

        public void sonuclar(RadioButton seciliolan)//Burada yeni bir method oluşturuyoruz.
        {//Her radiobutton için tek tek kodları yazmak yerine
         //method ile sadece dogru olan radiobutton'u gönderiyoruz.
         //Eğer method oluşturmasaydık "seciliolan" ifadesi yerine radiobutton ismi gelecek ve
         // aşağıdaki kodları soru sayısı kadar yazacaktık.
            if (seciliolan.Checked == true)
            {//Eğer metoda gönderilmiş olan radiobuttun işaretlenmiş ise
                dogru++;//Doğru sayısını arttır
                seciliolan.BackColor = Color.Green;//Arkaplanını yeşil yap
            }//http://www.programlamadersleri.com
            else
            {//Seçili olan radiobuttun yanlış ise

                yanlis++;//Yanlış sayısını arttır
            }
            labelDogruSayiSonuc.Text = dogru.ToString();
            //Doğru sonuç sayısını yazdırıyoruz.
            labelYanlisSayiSonuc.Text = yanlis.ToString();
            //Yanlış sonuç sayısını yazdırıyoruz.

        }//http://www.programlamadersleri.com

        public void grupFalse()
        {//Var olan groupbox'ları tek bir kod ile kapatmak için method oluşturuyoruz.
            //GroupBox içinde var olanları kullanılamaz hale getiriyoruz.
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }//http://www.programlamadersleri.com
        public void grupTrue()
        {//Var olan groupbox'ları tek bir kod ile açmak için method oluşturuyoruz.
            //GroupBox içinde var olanları yeniden kullanılabilir hale getiriyoruz.
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }

        public FormAdSoyad()
        {
            InitializeComponent();
        }
        //http://www.programlamadersleri.com
        private void timer1_Tick(object sender, EventArgs e)
        {//Timerımızı oluşturduk,Timer başlatılınca olacaklar aşağıda
            sayac--;//Sayac geri saymaya başlıyor
            labelSayac.Text = sayac.ToString();//Sayac değerini label'a yazdırıyoruz.
            if (sayac == 0)
            {//Eğer sayac 0'a eşit ise yani verilen süre bitmiş ise
                timer1.Enabled = false;//Timerı durduruyoruz.
                grupFalse();//Bütün groupBox'ları false ediyoruz.
                MessageBox.Show("Süreniz dolmuştur");
                //Kullanıcıya Süresinin bittiğini belirlen bir uyarı veriyoruz.
                //Formda bulunan butonları pasifleştiriyoruz.
                buttonTestBaslat.Enabled = false;
                buttonTestBitir.Enabled = false;
                //http://www.programlamadersleri.com
                //Soruların doğru cevaplarını sonuclar metoduna gönderiyoruz.
                sonuclar(radioButton4);
                sonuclar(radioButton5);
                sonuclar(radioButton11);
                sonuclar(radioButton16);

            }
        }

        private void buttonTestBaslat_Click(object sender, EventArgs e)
        {//Testi başlat butonuna tıklandığında;
            //http://www.programlamadersleri.com
            if ((textBoxTCNo.Text == "") || (textBoxAdSoyad.Text == ""))
            {//TC kimlik no ve ad soyad boş ise uyarı veriyoruz.
                MessageBox.Show("Lütfen gerekli bölümleri doldurunuz");
            }
            else if (textBoxTCNo.Text.Length != 11)
            {//TC kimlik no 11 değilse uyarı veriyoruz.
                MessageBox.Show("TC kimlik numaranız 11 haneden oluşmalıdır");
            }//http://www.programlamadersleri.com
            else
            {//Eğer yukarıdaki sorunlar aşılmış ise
                timer1.Enabled = true;//Timerı çalıştırıyoruz.
                grupTrue();//GroupBox'ları aktifleştiriyoruz
                labelTCNoSonuc2.Text = textBoxTCNo.Text; ;//Tc kimlik numarasını labela yazıdırıyoruz.
                labelAdSoyadSonuc2.Text = textBoxAdSoyad.Text;//Ad ve soyadı labela yazdırıyoruz.
                buttonTestBaslat.Enabled = false;//Testi başlat butonunu pasifleştiriyoruz.
            }
        }
        //http://www.programlamadersleri.com
        private void groupBox1_Enter(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void FormAdSoyad_Load(object sender, EventArgs e)
        {//Form ilk açıldığından Groupboxları false yapıyoruz.
            grupFalse();
        }
        //http://www.programlamadersleri.com
        private void buttonTestBitir_Click(object sender, EventArgs e)
        {//Testi bitir butonuna tıkladığımızda;
            grupFalse();//Groupboxları false yapıyoruz.
            buttonTestBitir.Enabled = false;//Testi bitir butonunu pasifleştiriyoruz
            timer1.Enabled = false;//Timer'ı kapatıyoruz.
            //http://www.programlamadersleri.com
            //Soruların doğru cevaplarını sonuclar metoduna gönderiyoruz.
            sonuclar(radioButton4);
            sonuclar(radioButton5);
            sonuclar(radioButton11);
            sonuclar(radioButton16);
        }
    }
}