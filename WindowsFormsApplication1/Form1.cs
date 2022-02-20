using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();     
            while (sayi<listBox1.Items.Count)
            {
                if (sayi / 2 == 1)
                {                                             
                    listBox2.Items.Add(listBox1.Items[sayi]);
                    sayi++;
                    break;
                }
                else if (sayi / 2 == 0) 
                {
                    listBox3.Items.Add(listBox1.Items[sayi]);
                    sayi++;
                    break;
                }
                textBox1.Text = "";
                textBox1.Focus();
            }

        }
    }
}
 