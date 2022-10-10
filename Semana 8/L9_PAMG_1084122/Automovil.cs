using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L9_PAMG_1084122
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

        public void setunTipoCambio (double T)

        { this.tipoCambioDolar = T; }


        public void setunCambiarDisponiblidad(bool D)

        { this.disponible = D; }


        public string getmostrarDisponiblidad()

        { return this.marca; }

        public string getmostrarInformacion()

        { return this.marca; }

        public void setAplicarDescuento(double Des)

        { this.descuentoAplicado = Des; }














    }
}
