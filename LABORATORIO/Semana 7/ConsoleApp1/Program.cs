using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_semana_8_ts_paula_Rios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese 3 números");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > 1)
            {
                Console.WriteLine("ingrese un número mayor a 0");
            }
            else if (b < 1)
            {
                Console.WriteLine("ingrese número mayor a 0");
            }
            else if (c > 1)
            {
                Console.WriteLine("ingrese número mayor a 0");
            }
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Mayor:" + a);
                }
                else if (a == c)
                { Console.WriteLine("Mayor:" + a); }

            }
            if (b > c)
            {
                Console.WriteLine("mayor:" + b);
            }
            else if (b == c)
            {
                Console.WriteLine("mayor:" + b);
            }
            else
            {
                Console.WriteLine("mayor: " + c);
            }
            Console.ReadKey();
        }
    }
}
