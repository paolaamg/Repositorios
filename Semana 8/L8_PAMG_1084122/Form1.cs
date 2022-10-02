using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2_PM_1084122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=int.Parse(textBox1.Text);
            int suma = 0;
                for(int i=1;i<=n; i++)
            {
                suma = suma + i;
            }
            label5.Text = Convert.ToString(suma);
              
        }
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j <= 9)
                    {
                        tabla = tabla + Convert.ToString(i * j) + "\t";
                    }
                    if (j == 10)
                    {
                        tabla = tabla + Convert.ToString(i * j) + "\n";
                    }
                }

            }
            label7.Text = Convert.ToString(tabla);
        }
    

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numero, c, x, b = 0;
            numero = Convert.ToInt32(textBox2.Text);
            c = numero / 2;
            for (int j = 1; j <= c; j++)
            {
                x = numero % j;

                if ( x== 0)
                    b = b + j;
            }
            if (b == numero)
                label8.Text = "El número " + numero + " es perfecto";
            else
                label8.Text = "El número " + numero + " no es perfecto";
        }
    }
}
