using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_PAMG_1084122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 10");
            Console.WriteLine("Ingrese el radio del circulo:");
            double radioIngresado = double.Parse(Console.ReadLine());

            // Variables para guardar los calculos
            double perimetroCalculado = 0;
            double areaCalculada = 0;
            double volumenCalculado = 0;
            // Objeto de tipo Circulo:
            Circulo objCirculo = new Circulo(radioIngresado);
            //Guardar los cálculos:
            objCirculo.CalcularGeometria(ref perimetroCalculado, ref areaCalculada,ref volumenCalculado);
            Console.WriteLine("Perímetro:" + perimetroCalculado);
            Console.WriteLine("Área:" + areaCalculada);
            Console.WriteLine("Volumen:" + volumenCalculado);

            Console.ReadKey();

        }
    }
}
class Circulo
{ private double radio;
    public Circulo(double Radio)
    {
        radio = Radio;
    }
    private double ObtenerPerimetro()
    { double perimetro = 2 * Math.PI * radio;
        return perimetro;
    }

    private double ObtenerArea()
    { double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }
    private double ObtenerVolumen()
    { double volumen = (4 * Math.PI * Math.Pow(radio, 3))/ 3;
        return volumen; }

    public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
    { unPerimetro=ObtenerPerimetro();
    unArea= ObtenerArea();
    unVolumen=ObtenerVolumen(); }

}
