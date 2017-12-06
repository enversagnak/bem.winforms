using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isUpdate;
        private int selectedRowIndex = -1;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < 5)
            {
                MessageBox.Show("Bütün alanları doldurmalısınız.");
                return;
            }

            var li = new ListViewItem(new[] { "",txtAd.Text, txtSoyad.Text, txtKimlikNo.Text, txtUzmanlik.Text });


            imageList2.Images.Add(pictureBox1.Image);

            li.ImageIndex = imageList2.Images.Count - 1;


            if (isUpdate)
            {
                //var li2 = listView1.SelectedItems[0];
                //li2.SubItems[0].Text = txtAd.Text;
                //li2.SubItems[1].Text = txtSoyad.Text;
                //li2.SubItems[2].Text = txtKimlikNo.Text;
                //li2.SubItems[3].Text = txtUzmanlik.Text;


                //listView1.SelectedItems[0] = li;
                //listView1.SelectedItems[0].SubItems[0].Text = txtAd.Text;
                listView1.Items[selectedRowIndex] = li;
            }
            else
            {
                listView1.Items.Add(li);
            }

            //var kisi = (isUpdate) ? (Kisi)lstKisi.SelectedItem : new Kisi();

            //kisi.Ad = txtAd.Text;
            //kisi.Soyad = txtSoyad.Text;
            //kisi.TcKimlikNo = txtKimlikNo.Text;
            //kisi.Uzmanlik = txtUzmanlik.Text;
            //kisi.IsActive = chkAktif.Checked;

            ////if (rdbCinsiyetKadin.Checked)
            ////{
            ////    kisi.Cinsiyet = Cinsiyet.Kadın;
            ////}
            ////else if (rdbCinsiyetErkek.Checked)
            ////{
            ////    kisi.Cinsiyet = Cinsiyet.Erkek;
            ////}

            //foreach (Control item in pnlCinsiyet.Controls)
            //{
            //    if(!(item is RadioButton))
            //    {
            //        continue;
            //    }

            //    var rb = item as RadioButton;

            //    if (rb.Checked)
            //    {
            //        kisi.Cinsiyet = (Cinsiyet)int.Parse(rb.Tag.ToString());
            //    }
            //}


            //if (!isUpdate)
            //{
            //    lstKisi.Items.Add(kisi);
            //}
            //else
            //{
            //    lstKisi.Items[lstKisi.SelectedIndex] = kisi;
            //}

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKimlikNo.Text = "";
            txtUzmanlik.Text = "";
            pictureBox1.Image = null;
            //chkAktif.Checked = true;

            //rdbCinsiyetErkek.Checked = false;
            //rdbCinsiyetKadin.Checked = false;

            isUpdate = false;
            selectedRowIndex = -1;
        }

        private void lstKisi_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if (e.Index < 0) return;
            ////if the item state is selected them change the back color 
            //if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            //    e = new DrawItemEventArgs(e.Graphics,
            //                              e.Font,
            //                              e.Bounds,
            //                              e.Index,
            //                              e.State ^ DrawItemState.Selected,
            //                              e.ForeColor,
            //                              Color.Yellow);//Choose the color

            //// Draw the background of the ListBox control for each item.
            //e.DrawBackground();
            //// Draw the current item text

            //var  box = (ListBox)sender;

            //var selectedItem = box.SelectedItem as Kisi;

            //var brush = (!(selectedItem is null) && selectedItem.IsActive) ? Brushes.Black : Brushes.Gray;

            //e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            //// If the ListBox has focus, draw a focus rectangle around the selected item.
            //e.DrawFocusRectangle();


            //Debug.WriteLine(e.Index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1.Items.Add("Ali");
            //listView1.Items[0].SubItems.Add("Aydın");
            //listView1.Items[0].SubItems[0].ForeColor = Color.Red;
            //listView1.Items[0].SubItems[1].ForeColor = Color.Blue;
            //var image = new Bitmap()

            //listView1.Items.Add("Ayşe");

            //var listItem = new ListViewItem("Mehmet");
            //listView1.Items.Add(listItem);

            //var li2Column = new ListViewItem(new[] { "Hasan", "Yavuz" });
            //listView1.Items.Add(li2Column);

            listView1.SmallImageList = imageList2;
            listView1.LargeImageList = imageList2;

        }

        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kisi = ((ListBox)sender).SelectedItem as Kisi;

            if(kisi is null)
            {
                return;
            }

            txtAd.Text = kisi.Ad;
            txtSoyad.Text = kisi.Soyad;
            txtKimlikNo.Text = kisi.TcKimlikNo;
            txtUzmanlik.Text = kisi.Uzmanlik;

            chkAktif.Checked = kisi.IsActive;


            if(kisi.Cinsiyet == Cinsiyet.Kadın)
            {
                rdbCinsiyetKadin.Checked = true;
            }
            else if (kisi.Cinsiyet == Cinsiyet.Erkek)
            {
                rdbCinsiyetErkek.Checked = true;
            }
            else if(kisi.Cinsiyet == Cinsiyet.Diger)
            {
                rbDiger.Checked = true;
            }

            isUpdate = true;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var lv = sender as ListView;
            //var lv = (ListView)sender;

            if (lv is null)
            {
                return;
            }

            var selectedItem = lv.SelectedItems[0];

            txtAd.Text = selectedItem.SubItems[1].Text;
            txtSoyad.Text = selectedItem.SubItems[2].Text;
            txtKimlikNo.Text = selectedItem.SubItems[3].Text;
            txtUzmanlik.Text = selectedItem.SubItems[4].Text;

            pictureBox1.Image = imageList2.Images[selectedItem.ImageIndex];

            isUpdate = true;
            selectedRowIndex = lv.SelectedIndices[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var img = new Bitmap(openFileDialog1.FileName);

            pictureBox1.Image = img;
            ProgresbarHesapla();
        }

        private void ProgresbarHesapla()
        {
            byte value = 0;

            if (!string.IsNullOrWhiteSpace(txtAd.Text))
            {
                value++;
            }

            if (!string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                value++;
            }

            if (!string.IsNullOrWhiteSpace(txtKimlikNo.Text))
            {
                value++;
            }

            if (!string.IsNullOrWhiteSpace(txtUzmanlik.Text))
            {
                value++;
            }

            if (pictureBox1.Image != null)
            {
                value++;
            }

            progressBar1.Value = value;
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            ProgresbarHesapla();
        }
        private string RandomKey()
        {
            int key = 0;
            Random rnd = new Random();
            key = rnd.Next(0, 1000);
            return key.ToString();
        }
        private string RandomKey2()
        {
            string key = "";
            Random rnd = new Random();
            for (int i = 0; i <3 ; i++)
            {
                key += ((char)rnd.Next(0, 65000)).ToString();
            }
            return key; 
            
        }
   
    }
}
