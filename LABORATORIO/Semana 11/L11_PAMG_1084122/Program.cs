using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_PAMG_1084122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Aseccion;
            Aseccion = new double[5];
            double[] Bseccion;
            Bseccion = new double[5];

            Console.WriteLine("Ingrese notas de la sección A");




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nota A" + (i + 1));
                
                Aseccion[i] = Convert.ToInt32(Console.ReadLine());

            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese notas de la sección B" + (i + 1));
               
                Bseccion[i] = Convert.ToInt32(Console.ReadLine());

            }

            int notas1 =0;
            int notas2 = 0;



            for (int i = 0; i < 5; i++)
            {    if (Aseccion[i] >= 65)
                {
                    notas1++;
                }
              else
                {
                    notas2++;
                }

             

                
            }
            float A1porcentaje = (notas1 * 100) / 5;
            float A2porcentaje = (notas2 * 100) / 5;
           


            Console.WriteLine("El porcentaje de aprobados de la sección A es de " + A1porcentaje);
            Console.WriteLine("El porcentaje de desaprobados de la sección A es de " + A2porcentaje);
            


            int notas3 = 0;
            int notas4 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (Aseccion[i] >= 65)
                {
                    notas3++;
                }
                else
                {
                    notas4++;
                }


            }


            float B1porcentaje = (notas3 * 100) / 5;
            float B2porcentaje = (notas4 * 100) / 5;
            float BTporcentaje = ((notas3 + notas4+ notas1+ notas2) * 100) / 10;

            Console.WriteLine("El porcentaje de aprobados de la sección B es de " + B1porcentaje);
            Console.WriteLine("El porcentaje de desaprobados de la sección B es de " + B2porcentaje);
            Console.WriteLine("El porcentaje total es de " + BTporcentaje);


            {
                int notasA = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (Aseccion[i] <= 75)
                    {
                        notasA++;
                    }
                }
                int notasB = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (Bseccion[i] <= 75)
                    {
                        notasB++;


                    }
                }

                int cant75 = notasA + notasB;
                Console.WriteLine("La cantidad de estudiantes que tenga un promedio por encima de 75 es de  " + cant75);




                
                for (int i = 0; i < 5; i++)
                {
                    if (Aseccion[i] >= 90)
                    {
                        notasA++;
                    }
                }
                

                for (int i = 0; i < 5; i++)
                {
                    if (Bseccion[i] >= 90)
                    {
                        notasB++;


                    }
                }

                int cant90 = notasA + notasB;
                Console.WriteLine("La cantidad de estudiantes que tenga un promedio por encima de 90 es de " + cant90);






            }



            Console.ReadKey();
        }
        
    }
}