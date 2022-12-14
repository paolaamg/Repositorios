using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L9_PM_1084122
{
    internal class Automovil
    {
        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambioDolar;
        private double descuentoAplicado;

        public Automovil()
        {
            this.modelo = 2019;
            this.precio = 10000;
            this.marca = "";
            this.disponible = false;
            this.tipoCambioDolar = 7.50;
            this.descuentoAplicado = 0.00;

        }

        public void setunModelo(int m)

        { this.modelo = m; }

        public void setunPrecio(double p)

        { this.precio = p; }

        public void setunMarca(string ma)

        { this.marca = ma; }

        public void setunTipoCambio(double T)

        { this.tipoCambioDolar = T; }

        public double PrecioDolares()
        {
            double precioDolar = 0;
            precioDolar = this.precio / this.tipoCambioDolar;
            return precioDolar;
        }
        public void CambiarDisponiblidad(bool Descuento)

        {
            this.disponible = Descuento;
            if (Descuento == true)
            { Descuento = false; }
            else
            { Descuento = true; }

        }


        public string MostrarDisponibilidad()
        {
            string texto = "";
            if (disponible == true)
            {
                texto = ("Disponible");
            }
            else
            {
                texto = "“No se encuentra disponible actualmente";
            }
            return texto;
        }



        public string MostrarInformacion()
        {
            string texto = "Marca: " + this.marca + Environment.NewLine + "Modelo: " + this.modelo + Environment.NewLine + "Precio de venta: Q" + this.precio + Environment.NewLine + "Precio en dolares $" + PrecioDolares() + Environment.NewLine + MostrarDisponibilidad();

            return texto;

        }

        public void setAplicarDescuento(double Desc)

        {
            descuentoAplicado = Desc;
            this.precio = this.precio - descuentoAplicado;
            setunPrecio(this.precio);
        }

        internal void CambiarDisponiblidad()
        {
            throw new NotImplementedException();
        }
    }

}