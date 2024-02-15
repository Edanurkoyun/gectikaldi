using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gectikaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            int ortalama,sinav1,sinav2;
            sinav1=Convert.ToInt32(textBox2.Text);
            sinav2 = Convert.ToInt32(textBox3.Text);
            ortalama=(sinav1+sinav2)/2;
            listBox4.Items.Add(ortalama.ToString());
            if (ortalama < 50)
            {
                listBox5.Items.Add("Kaldi");
            }
            else
            {
                listBox5.Items.Add("Gecti");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }
    }
}
