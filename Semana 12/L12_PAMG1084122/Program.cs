using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_PAMG1084122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] m = new double[4, 5];
            double[,] e = new double[4, 5];
            double[,] s = new double[4, 5];

            double A = 0;
            double C = 0;
            double prom;
            Random rand = new Random();



            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    
                    e[i, j] = rand.Next(100);
                    A = A + e[i, j];
                    C++;
                }
            }


            prom = A / C;
            Console.WriteLine("Primer Ejercicio");
            Console.WriteLine(" Suma de la matriz A " + A);
            Console.WriteLine(" Promedio de la matriz A " + prom);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    m[i, j] = rand.Next(100);
                }
            }
            Console.WriteLine("Segundo Ejercicio");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    s[i, j] = m[i, j] + e[i, j];
                    Console.WriteLine("Fila  " + i + " columna " + j);
                }
            }
            Console.ReadKey();
        }
    }
} 
