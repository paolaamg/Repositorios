using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T9_PAMG_1084122
{
    public partial class Form1 : Form
    {
        Motocicleta objMotocicleta = new Motocicleta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objMotocicleta.Vender();
            textBox1 = objMotocicleta.MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            int modelo;
            string marca;
            double precio, iva;
            modelo = Convert.ToInt32(textBox2);
            marca = textBox3;
            precio = Convert.ToDouble(textBox4.Text);
            iva = Convert.ToDouble(textBox5.Text);
            objMotocicleta.DefinirModelo(modelo);
            objMotocicleta.DefinirMarca(marca);
            objMotocicleta.DefinirPrecio(precio);
            objMotocicleta.DefinirIva(iva);
            textBox1.Text = objMotocicleta.MostrarDatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            objMotocicleta.Devolver();
            textBox1.Text = objMotocicleta.MostrarDatos();
        }
    }
}
