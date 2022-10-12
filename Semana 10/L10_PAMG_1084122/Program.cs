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
        {   int intentos=1;
            string usuario;
            string contrasena;
            bool resultado=false;
            int ciclo = 0;
            

            while (ciclo < 3 )
            {
                Console.WriteLine("Por favor, ingrese el usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Por favor, ingrese la contraseña:");
                contrasena = Console.ReadLine();
                resultado = Login(usuario, contrasena);


                if (resultado)
                {
                    ciclo = 3;
                    Console.WriteLine("Correcto, ingresó" + intentos + "intentos");

                }

                else
                {
                    Console.WriteLine("Error, intentelo de nuevo, lleva " + intentos + "intentos");
                    intentos++;
                    ciclo++;
                }




            }

            if (intentos == 3)
            {
                Console.WriteLine("Lo sentimos, ha llegado al máximo de intentos");
            }
           Console.ReadKey();


        }

        public static bool Login(string user, string pass)
        {

            if (user == "usuario1" && pass == "asdasd")
            {
                return true;
            }
            else
            { return false; 
                
            }



        }





    }
}
