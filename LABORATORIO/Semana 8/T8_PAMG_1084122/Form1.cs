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
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e, TextBox hexa)
        {
            string Hexa = "equivalente hexadecimal";
            int Numero = int.Parse(textBox3.Text);

            while (Numero > 0)
            {

                switch (Numero % 16)
                {
                    case 10:
                        Hexa = "A" + Hexa;
                        break;
                    case 11:
                        Hexa = "B" + Hexa; 
                        break;
                    case 12:
                        Hexa = "C" + Hexa;
                        break;
                    case 13:
                        Hexa = "D" + Hexa;
                        break;
                    case 14:
                        Hexa = "E" + Hexa;
                        break;
                    case 15:
                        Hexa = "F" + Hexa;
                        break;default:
                        Hexa = (Numero % 16) + Hexa; 
                        break;

                }

                Numero = (int)Numero / 16;
            }

            textBox3 = hexa;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

