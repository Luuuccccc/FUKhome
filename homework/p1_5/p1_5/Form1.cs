using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = "";
            int a = 0;
            int b = 0;
            int sum = 0;
            n = textBox1.Text;
            a = Int32.Parse(n);
            n = textBox2.Text;
            b = Int32.Parse(n);
            sum = a * b;
            label1.Text = sum.ToString();
            Console.WriteLine(sum);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
