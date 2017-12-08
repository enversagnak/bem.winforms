using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsAs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //for (int i = 0; i < 50; i++)
            //{
            //    var button = new Button();
            //    button.Size = new Size(40, 20);

            //    flowLayoutPanel1.Controls.Add(button);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(button1 is Button); 
            listBox1.Items.Add(button1 is ButtonBase);
            listBox1.Items.Add(button1 is Control);
            listBox1.Items.Add(button1 is Component);
            listBox1.Items.Add(button1 is object);
            listBox1.Items.Add(button1 is null);
            listBox1.Items.Add("==========");
            listBox1.Items.Add(button1 is Form);
            listBox1.Items.Add(button1 is List<string>);
            listBox1.Items.Add(button1 is StringBuilder);
            listBox1.Items.Add("==========");
            listBox1.Items.Add(button1 is Control);
            listBox1.Items.Add(listBox1 is Control);
            listBox1.Items.Add(listBox2 is Control);



            Button b1 = button1 as Button;
            object b2 = button1 as Button;

            ListBox l1 = b2 as ListBox;
            //ListBox l2 = (ListBox)b2;
            listBox2.Items.Add(l1 is null);

            Button b3 = b2 as Button;
            listBox2.Items.Add(b3 is null);



        }
    }
}
