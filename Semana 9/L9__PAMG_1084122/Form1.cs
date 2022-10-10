using L9_PM_1084122;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace L9__PAMG_1084122
{
    public partial class Form1 : Form
    {
        Automovil objAutomovil= new Automovil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        double descuento;
        descuento = Convert.ToDouble(textBox5.Text);
        miAutomovil.AplicarDescuento(descuento);
        Limpiar();
        textBox6.Text = miAutomovil.MostrarInformacion();
    }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          Limpiar();
         objAutomovil.CambiarDisponibilidad();
         textBox6.Text = miAutomovil.MostrarInformacion();
    }

        private void button3_Click(object sender, EventArgs e)
        {
        tabControl1.SelectedIndex = 1;
        button1.Enabled = true;
        button2.Enabled = true;
        string marca;
        int modelo;
        double precio, tipoCambio;
        modelo = Convert.ToInt16(textBox1.Text);
        precio = Convert.ToDouble(textBox2.Text);
        marca = textBox3.Text;
        tipoCambio = Convert.ToDouble(textBox4.Text);
        objAutomovil.setunMarca(marca);
        objAutomovil.setunModelo(modelo);
        objAutomovil.setunPrecio(precio);
        objAutomovil.setunTipoCambio(tipoCambio);
        textBox6.Text = objAutomovil.MostrarInformacion();


    }
    }
}
