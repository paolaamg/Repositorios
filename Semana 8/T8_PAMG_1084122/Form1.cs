using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T8_PAMG_1084122
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBox1.Text);
            int x = p;
            int res;
            string bin = string.Empty;

            while (p > 0)
            {
                res = p % 2;
                p /= 2;
                bin = res.ToString() + bin;
            }
            label2.Text = x + " el resultado es" + bin;
        }
    

        private void label2_Click(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBox1.Text);
            int x = s;
            int res;
            string bin = string.Empty;

            while (s > 0)
            {
                res = s % 16;
                s /= 16;
                bin = res.ToString() + bin;
            }
            label4.Text = x + " el resultado es" + bin;
        }
    }
}
