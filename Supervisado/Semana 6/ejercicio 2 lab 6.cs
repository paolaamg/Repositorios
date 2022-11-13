using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meses = "mes ";
            Console.WriteLine("ingrese mes");
            int mes = Int32.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.WriteLine(mes + "enero");
                    break;
                case 2:
                    Console.WriteLine(mes + "febrero");
                    break;
                case 3:
                    Console.WriteLine(mes + "marzo");
                    break;
                case 4:
                    Console.WriteLine(mes + "abril");
                    break;
                case 5:
                    Console.WriteLine(mes + "mayo");
                    break;
                case 6:
                    Console.WriteLine(mes + "junio");
                    break;
                case 7:
                    Console.WriteLine(mes + "julio");
                    break;
                case 8:
                    Console.WriteLine(mes + "agosto");
                    break;
                case 9:
                    Console.WriteLine(mes + "septiembre");
                    break;
                case 10:
                    Console.WriteLine(mes + "octubre");
                    break;
                case 11:
                    Console.WriteLine(mes + "noviembre");
                    break;
                case 12:
                    Console.WriteLine(mes + "diciembre");
                    break;
                default:
                    Console.WriteLine("el mes no es válido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
