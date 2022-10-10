using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_PAMG_1084122
{
    internal class Motocicleta
    {
        public int Modelo;
        private double Precio;
        private string Marca;
        private double Iva;
        private bool Vendida;

        public Motocicleta()
        {
            this.Modelo = 2019;
            this.Precio = 1000;
            this.Marca = "";
            this.Iva = 0.12; }



        public void DefinirPrecio(double precio)
        {
            this.Precio = precio; }
        public void DefinirModelo(int modelo)
        {
            this.Modelo = modelo; }
        public void DefinirMarca(string marca)
        {
            this.Marca = marca; }

        public void DefinirIva(double Iva)
        {
            if (Iva >= 0.01 && Iva <= 0.99)
            {
                this.Iva = Iva;
            }
        }

        public double PrecioSinIva()
        {
            return this.Precio;
        }

        public double PrecioConIva()
        {
            double iva, precioconiva;
            iva = this.Precio * this.Iva;
            precioconiva = this.Precio + iva;
            return precioconiva;
        }
        public double DevolverIva()
        {
            double iva;
            iva = this.Precio * this.Iva;
            return iva;
        }




        public void Vender()
        {
            this.Vendida = true;
        }
        public void Devolver()
        {
            this.Vendida = false;
        }
        public string MostrarDisponibilidad()
        {
            string texto = "";
            if (Vendida == true)
            {
                texto = ("Venta realizada");
            }
            else
            {
                texto = "Motocicleta disponible";
            }
            return texto;
        }



        public string MostrarDatos()
        {
            string texto = "Modelo: " + this.Modelo + Environment.NewLine + "Marca: " + this.Marca + Environment.NewLine + "Precio Sin IVA: Q" + PrecioSinIva() + Environment.NewLine + "Precio con IVA: Q" + PrecioConIva() + Environment.NewLine + "Monto del IVA: Q" + DevolverIva() + Environment.NewLine + MostrarDisponibilidad();
            return texto;
        }
    }
}
