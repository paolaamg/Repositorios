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
        }
    }
}
class Circulo
{ private double radio;
    public Circulo (double Radio)
    {
        radio = Radio;
        }
    private double ObtenerPerimetro()
    { double perimetro= 2*Math.PI*radio;
        return perimetro;
    }
        
    private double ObtenerArea()
    { double area= Math.PI * MathPow(radio,2);
        return area;
    }
    private double ObtenerVolumen()
    { double volumen=(4*Math.PI)*Math.Pow(radio,3))/3;
    return volumen;}


}
