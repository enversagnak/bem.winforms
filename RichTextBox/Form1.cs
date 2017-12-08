using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur a maximus quam. Ut vehicula a mauris id aliquam. Morbi faucibus consequat interdum. Morbi cursus leo eu augue iaculis, et blandit eros finibus. Donec efficitur condimentum velit. Nam in augue at lacus mattis fringilla. Integer quis orci diam. Aenean eget tristique urna, eget varius libero. Ut id mollis magna.

Etiam sed accumsan risus, vitae gravida ex. Donec ex risus, mollis quis pulvinar nec, vehicula quis nisi. Integer eleifend urna sed tortor venenatis feugiat vitae in mi. Nam sagittis est at tincidunt dignissim. Curabitur nec ligula luctus, sollicitudin ligula at, aliquet nulla. Praesent vitae iaculis libero. Proin dignissim interdum commodo. Nam nec aliquam magna.";
        }

        private void btnFontSec_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void btnSolaYasla_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnOrtala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnSagaYasla_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void menuItemYeni_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void menuItemAç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            var reader = new StreamReader(openFileDialog1.FileName, Encoding.Default);

            var text = reader.ReadToEnd();

            richTextBox1.Text = text;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            using (var streamWriter = new StreamWriter(saveFileDialog1.FileName, true))
            {
                streamWriter.Write(richTextBox1.Text);
            }
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var selectionStart = richTextBox1.SelectionStart;
            var selectionEnd = richTextBox1.SelectionStart+ richTextBox1.SelectionLength;

            for (int i = selectionStart; i < selectionEnd; i++)
            {
                richTextBox1.SelectionStart = i;
                richTextBox1.SelectionLength = 1;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
            }

            //richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void cmenuStyle_Opened(object sender, EventArgs e)
        {
            kalınToolStripMenuItem.Checked = richTextBox1.SelectionFont.Bold;
            italikToolStripMenuItem.Checked = richTextBox1.SelectionFont.Italic;
            altçizgiliToolStripMenuItem.Checked = richTextBox1.SelectionFont.Underline;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 8);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 10);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 12);
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, float.Parse(((ToolStripTextBox)sender).Text));
            }
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, float.Parse(((ToolStripTextBox)sender).Text));
        }

        private void cmenuStyle_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
            {
                return;
            }

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, float.Parse(toolStripTextBox1.Text));
        }

        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var selectionStart = richTextBox1.SelectionStart;
            var selectionEnd = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            for (int i = selectionStart; i < selectionEnd; i++)
            {
                richTextBox1.SelectionStart = i;
                richTextBox1.SelectionLength = 1;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
            }
            
        }

        private void altçizgiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectionStart = richTextBox1.SelectionStart;
            var selectionEnd = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            for (int i = selectionStart; i < selectionEnd; i++)
            {
                richTextBox1.SelectionStart = i;
                richTextBox1.SelectionLength = 1;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
            }
            
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, (sender as TrackBar).Value);
        }

        private void RenkSec()
        {
            var color =Color.FromArgb(trackBar2.Value, trackBar3.Value, trackBar4.Value);

            richTextBox1.SelectionColor = color;

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            RenkSec();
        }
    }
}
