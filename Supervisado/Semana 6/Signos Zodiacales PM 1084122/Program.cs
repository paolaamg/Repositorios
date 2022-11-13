using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signos_Zodiacales_PM_1084122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea Paola Morales");
            Console.WriteLine("¿Cuál es el año de su nacimiento?");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuál es el mes de su nacimiento?");
            string mes = Console.ReadLine();
            Console.WriteLine("¿Cuál es el día de su nacimiento?");
            int dia = int.Parse(Console.ReadLine());

            //mese = mese.ToUpper();

            Console.Write("Su signo es ");

            if ((dia > 0) && (dia <= 31))
            {
                if (mes.Equals("MARZO"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Aries");
                    else
                        Console.WriteLine("Piscis");
                }
                else if (mes.Equals("ABRIL"))
                {
                    if (dia >= 20)
                        Console.WriteLine("Tauro");
                    else
                        Console.WriteLine("Aries");
                }
                else if (mes.Equals("MAYO"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Géminis");
                    else
                        Console.WriteLine("Tauro");
                }
                else if (mes.Equals("JUNIO"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Cancer");
                    else
                        Console.WriteLine("Géminis");
                }
                else if (mes.Equals("JULIO"))
                {
                    if (dia >= 23)
                        Console.WriteLine("Leo");
                    else
                        Console.WriteLine("Cancer");
                }
                else if (mes.Equals("AGOSTO"))
                {
                    if (dia >= 23)
                        Console.WriteLine("Virgo");
                    else
                        Console.WriteLine("Leo");
                }
                else if (mes.Equals("SEPTIEMBRE"))
                {
                    if (dia >= 23)
                        Console.WriteLine("Libra");
                    else
                        Console.WriteLine("Virgo");
                }
                else if (mes.Equals("OCTUBRE"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Escorpio");
                    else
                        Console.WriteLine("Libra");
                }
                else if (mes.Equals("NOVIEMBRE"))
                {
                    if (dia >= 22)
                        Console.WriteLine("Sagitario");
                    else
                        Console.WriteLine("Escorpio");
                }
                else if (mes.Equals("DICIEMBRE"))
                {
                    if (dia >= 22)
                        Console.WriteLine("Capricornio");
                    else
                        Console.WriteLine("Sagitario");
                }
                else if (mes.Equals("ENERO"))
                {
                    if (dia >= 20)
                        Console.WriteLine("Acuario");
                    else
                        Console.WriteLine("Capricornio");
                }
                else if (mes.Equals("FEBRERO"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Piscis");
                    else
                        Console.WriteLine("Acuario");
                }
            }
            else
                Console.WriteLine("El día debe ser mayor a 0 y menor a 31");

            {
                Console.ReadKey();
            }
        }
    }
}
