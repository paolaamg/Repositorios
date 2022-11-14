using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables generales
            int op = 0;
            int op2 = 0;
            int numventilacion;
            double [] temperaturamin = new double[4];
            double[] temperaturamax = new double[4];
            double a1 = 0;
            double a2 = 0;
            double humedad1;
            double humedad2;
            double humedad3;
            double humedad4;
            string horacompu = Convert.ToString(DateTime.Now.ToString("HH:mm"));

            // Repetición del menú de opciones principal
            while (op != 5)
            {
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("\n Bienvenido al sistema de automatización del hogar.    _");
                Console.WriteLine(" ¿Qué desea configurar? Elija las opciones:            _");
                Console.WriteLine("         1. Ventilación                                _");
                Console.WriteLine("         2. Calefacción                                _");
                Console.WriteLine("         3. Iluminación                                _");
                Console.WriteLine("         4. Panel de Control                           _");
                Console.WriteLine("         5. Salir                                      _\n");

                Console.Write(" Ingrese opción:   ");
                op = Convert.ToInt32(Console.ReadLine());
                while (op < 1 || op > 5)
                {
                    Console.WriteLine("\n La opción no se encuentra dentro del rango de opciones. Inténtelo de nuevo");
                    Console.Write(" Ingrese opción:  ");
                    op = Convert.ToInt32(Console.ReadLine());
                }

                // Menú de opciones principal, para ls funciones generales del sistema
                switch (op)
                {
                    case 1:
                        Console.WriteLine(" No tiene acceso para esta configuración.\n");
                        break;
                    case 2:
                        Console.WriteLine(" No tiene acceso para esta configuración.\n ");
                        break;
                    case 3:
                        Console.WriteLine(" No tiene acceso para esta configuración.\n");
                        break;
                    case 4:
                        {
                            //Validación del menú de opciones secundario
                            while (op2 != 4)
                            {
                                int ophab;
                                Console.WriteLine(".................................................");
                                Console.WriteLine("\n Ha entrado al panel de control. Bienvenido.    .");
                                Console.WriteLine(" ¿Qué desea configurar el día de hoy?           .");
                                Console.WriteLine("         1: Horario de ventilación              .");
                                Console.WriteLine("         2: Temperaturas máximas y mínimas      .");
                                Console.WriteLine("         3: Promedio de las temperaturas        .");
                                Console.WriteLine("         4: Salida                              .\n");
                                
                                Console.Write(" Ingrese número opción:  ");
                                op2 = Convert.ToInt32(Console.ReadLine());
                               
                                while (op2 < 1 || op2 > 4)
                                {
                                    Console.WriteLine("\n La opción no se encuentra dentro del rango de opciones. Inténtelo de nuevo ");
                                    Console.Write(" Ingrese opción:  ");
                                    op2 = Convert.ToInt32(Console.ReadLine());
                                }
                                //Menú de opciones secundario. Presenta las opciones del panel de control
                                switch (op2)
                                {
                                    case 1:
                                        { //VENTILACIÓN
                                            Console.WriteLine("\n ***Accedió a la configuración del horario de ventilación***");
                                            Console.Write(" Ingrese cantidad de veces que desea programar la ventilación para sus 4 habitaciones:  ");
                                            numventilacion = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine(" ");

                                            //Declaración de vectores para encender y apagar la luz
                                            string[] ventilacionencender;
                                            ventilacionencender = new string[numventilacion];
                                            string[] ventilacionapagar;
                                            ventilacionapagar= new string[numventilacion];

                                            //Variables de validación de la hora por medio de subcadenas
                                            string horaencender;
                                            int horaenteroencender;
                                            string horaapagar;
                                            int horaenteroapagar;
                                            string dospuntosencender;
                                            string dospuntosapagar;

                                            for (int i = 0; i < numventilacion; i++)
                                            {                                               
                                                Console.Write(" ¿A qué hora desea encender la ventilación? 1 a 24 horas, con horas y minutos:   ");
                                                ventilacionencender[i] = Console.ReadLine();
                                                horaencender = ventilacionencender[i].Substring(0, 2);
                                                horaenteroencender = Convert.ToInt32(horaencender);
                                                dospuntosencender = ventilacionencender[i].Substring(2, 1);
                                                Console.WriteLine(dospuntosencender);


                                                while (horaenteroencender < 1 || horaenteroencender > 24)
                                                {
                                                  Console.WriteLine("\n Error, el horario ingresado no corresponde al formato de 24 horas. Inténtelo de nuevo.");
                                                  Console.Write(" ¿A qué hora desea encender la ventilación?:  ");
                                                  ventilacionencender[i] = Console.ReadLine();
                                                  horaencender = ventilacionencender[i].Substring(0, 2);
                                                  horaenteroencender = Convert.ToInt32(horaencender);
                                                }
                                                while (dospuntosencender != ":")
                                                {
                                                    Console.WriteLine("\n Error, formato de hora incorrecto. Asegúrese de utilizar dos puntos (:) ");
                                                    Console.Write("\n ¿A qué hora desea encender la ventilación?: ");
                                                    ventilacionencender[i] = Console.ReadLine();
                                                    dospuntosencender = ventilacionencender[i].Substring(2,1);
                                                }                                               
                                            }

                                            for (int i = 0; i < numventilacion; i++)
                                            {
                                                Console.Write(" ¿A qué hora desea apagar la ventilación? 1 a 24 horas:  ");
                                                ventilacionapagar[i] = Console.ReadLine();
                                                horaapagar = ventilacionapagar[i].Substring(0, 2);
                                                horaenteroapagar = Convert.ToInt32(horaapagar);
                                                dospuntosapagar = ventilacionapagar[i].Substring(2, 1);
                                                Console.WriteLine(dospuntosapagar);


                                                while (horaenteroapagar < 1 || horaenteroapagar > 24)
                                                {
                                                    Console.WriteLine("\n Error, el horario ingresado no corresponde al formato de 24 horas. Inténtelo de nuevo.");
                                                    Console.WriteLine(" ¿A qué hora desea apagar la ventilación?:  ");
                                                    ventilacionapagar[i] = Console.ReadLine();
                                                    horaapagar = ventilacionapagar[i].Substring(0, 2);
                                                    horaenteroapagar = Convert.ToInt32(horaapagar);
                                                }
                                                while (dospuntosapagar != ":")
                                                {
                                                    Console.WriteLine("\n Error, formato de hora incorrecto. Asegúrese de utilizar dos puntos (:)");
                                                    Console.WriteLine(" ¿A qué hora desea apagar la ventilación?:  ");
                                                    ventilacionapagar[i] = Console.ReadLine();
                                                    dospuntosapagar = ventilacionapagar[i].Substring(2, 1);                                                  

                                                }
                                            }
                                            ophab = 0;
                                            while(ophab != 5)
                                            {
                                                //Menú de opciones para configurar cada habitación. El programa cuenta con 4 habitaciones de manera delimitada.
                                                Console.WriteLine("\n********CONFIGURACIÓN DE HABITACIONES*******\n");
                                                Console.WriteLine("         1. Habitación 1                     *");
                                                Console.WriteLine("         2. Habitación 2                     *");
                                                Console.WriteLine("         3. Habitación 3                     *");
                                                Console.WriteLine("         4. Habitación 4                     *");
                                                Console.WriteLine("         5. Salir de la configuración de habitaciones\n");
                                                Console.Write("Ingrese al número de habitación que desea configurar: ");
                                                ophab = Convert.ToInt32(Console.ReadLine());
                                                //Validación de la opción del usuario
                                                while (ophab<1 || ophab > 5)
                                                {
                                                    Console.WriteLine(" No ha ingresado una opción correcta. Inténtelo de nuevo");
                                                    Console.Write(" Ingrese al número de habitación que desea configurar: ");
                                                    ophab = Convert.ToInt32(Console.ReadLine());
                                                }


                                                //Menú de opciones para cada habitación.
                                                switch (ophab)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\n------ VENTILACIÓN DE LA HABITACIÓN 1 ------\n");
                                                            Console.Write("Ingrese cantidad de humedad en la habitación 1:  ");
                                                            humedad1 = Convert.ToDouble(Console.ReadLine());
                                                            Console.WriteLine("");
                                                            //Validación del valor mínimo y máximo de la humedad
                                                            while (humedad1 < 40 || humedad1 > 90)
                                                            {
                                                                Console.Write(" Error. Usted está ingresando una humedad menor a los niveles estándar. Ingrese una humedad de 40% a 60%");
                                                                Console.Write(" \nIngrese cantidad de humedad en la habitación  ");
                                                                humedad1 = Convert.ToDouble(Console.ReadLine());
                                                            }
                                                            //La ventilación encenderá si la humedad excede del 70%, de lo contrario indicará si se encuentra encendida o apagada.
                                                            if (humedad1 > 70)
                                                            {
                                                                Console.WriteLine("\n Ventilación: ENCENDIDA");
                                                            }
                                                            else
                                                            {
                                                                for (int i = 0; i < numventilacion; i++)
                                                                {
                                                                    if (ventilacionencender[i] == horacompu)
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación está encendida");
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación se encuentra apagada actualmente. ");
                                                                        Console.WriteLine("La ventilación se encenderá a las " + ventilacionencender[i] + " horas");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 2:
                                                        {
                                                            Console.WriteLine("\n------ VENTILACIÓN DE LA HABITACIÓN 2 ------\n");
                                                            Console.Write(" Ingrese cantidad de humedad en la habitación 2:  ");
                                                            humedad2 = Convert.ToDouble(Console.ReadLine());
                                                            while (humedad2 < 40 || humedad2 > 90)
                                                            {
                                                                Console.Write("Error. Usted está ingresando una humedad menor a los niveles estándar. Ingrese una humedad de 40% a 60%");
                                                                Console.Write(" \nIngrese cantidad de humedad en la habitación  ");
                                                                humedad2 = Convert.ToDouble(Console.ReadLine());
                                                            }
                                                            if (humedad2 > 70)
                                                            {
                                                                Console.WriteLine("\n Ventilación: ENCENDIDA");
                                                            }
                                                            else
                                                            {
                                                                for (int i = 0; i < numventilacion; i++)
                                                                {
                                                                    if (ventilacionencender[i] == horacompu)
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación está encendida");
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación se encuentra apagada actualmente. ");
                                                                        Console.WriteLine("La ventilación se encenderá a las " + ventilacionencender[i] + " horas");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 3:
                                                        {
                                                            Console.WriteLine("\n------ VENTILACIÓN DE LA HABITACIÓN 3 ------\n");
                                                            Console.Write(" Ingrese cantidad de humedad en la habitación 3:  ");
                                                            humedad3 = Convert.ToDouble(Console.ReadLine());
                                                            while (humedad3 < 40 || humedad3 > 90 )
                                                            {
                                                                Console.Write("Error. Usted está ingresando una humedad menor a los niveles estándar. Ingrese una humedad de 40% a 90%");
                                                                Console.Write(" \nIngrese cantidad de humedad en la habitación  ");
                                                                humedad3 = Convert.ToDouble(Console.ReadLine());
                                                            }
                                                            if (humedad3 > 70)
                                                            {
                                                                Console.WriteLine("\n Ventilación: ENCENDIDA");
                                                            }
                                                            else
                                                            {
                                                                for (int i = 0; i < numventilacion; i++)
                                                                {
                                                                    if (ventilacionencender[i] == horacompu)
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación está encendida");
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación se encuentra apagada actualmente. ");
                                                                        Console.WriteLine("La ventilación se encenderá a las " + ventilacionencender[i] + " horas");
                                                                    }
                                                                }
                                                            }

                                                        }
                                                        break;
                                                    case 4:
                                                        {
                                                            Console.WriteLine("\n------ VENTILACIÓN DE LA HABITACIÓN 4 ------\n");
                                                            Console.Write(" Ingrese cantidad de humedad en la habitación 4: ");
                                                            humedad4 = Convert.ToDouble(Console.ReadLine());
                                                            while (humedad4 < 40)
                                                            {
                                                                Console.Write(" Error. Usted está ingresando una humedad menor a los niveles estándar. Ingrese una humedad de 40% a 60%");
                                                                Console.Write(" \nIngrese cantidad de humedad en la habitación  ");
                                                                humedad4 = Convert.ToDouble(Console.ReadLine());
                                                            }
                                                            if (humedad4 > 70)
                                                            {
                                                                Console.WriteLine("\n Ventilación: ENCENDIDA");
                                                            }
                                                            else
                                                            {
                                                                for (int i = 0; i < numventilacion; i++)
                                                                {
                                                                    if (ventilacionencender[i] == horacompu)
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación se encuentra encendida");
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nLa ventilación se encuentra apagada actualmente. ");
                                                                        Console.WriteLine("La ventilación se encenderá a las " + ventilacionencender[i] + " horas");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    case 5:
                                                        break;
                                                }                                               
                                            }
                                            //El proceso de horas de ventilación es finalizado.
                                            Console.WriteLine("\nLas horas de ventilacion se registraron correctamente.");
                                            Console.WriteLine("Ventilación configurada con éxito.");
                                        }
                                        break;
                                    case 2:
                                        {           
                                            //CONFIGURACIÓN DE TEMPERATURAS     
                                            Console.WriteLine("\n ***Accedió a la configuración de las temperaturas máximas y mínimas***");
                                            Console.WriteLine(" /CONFIGURACIÓN DE TEMPERATURAS MÍNIMAS/");
                                            Console.WriteLine("");
                                            temperaturamin = new double[4];
                                            //Llenado de los vectores de temperatura mínima para cada habitación con su respectiva validación
                                            for (int i = 0; i < 4; i++)
                                            {

                                                Console.Write(" Ingrese temperatura mínima para la habitación "+(i+1)+" : ");
                                                temperaturamin[i] = Convert.ToDouble(Console.ReadLine());

                                                while (temperaturamin[i] < 18 || temperaturamin[i] > 40)
                                                {
                                                    Console.WriteLine(" No es posible configurar una temperatura mayor a 40 grados ni menor a 18. Inténtelo de nuevo.");
                                                    Console.Write(" Ingrese temperatura mínima para la habitación " +(i+1)+" : ");
                                                    temperaturamin[i] = Convert.ToDouble(Console.ReadLine());
                                                }
                                                if (temperaturamin[i] == 22)
                                                {
                                                    Console.WriteLine(" Ha ingresado una temperatura ideal");

                                                }
                                                
                                            }

                                            Console.WriteLine(" Ha finalizado la configuración de temperaturas mínimas\n");
                                            Console.WriteLine("\n /CONFIGURACIÓN TEMPERATURAS MÁXIMAS/");
                                            temperaturamax = new double[4];
                                            //Llenado de los vectores de temperatura mínima para cada habitación con su respectiva validación

                                            for (int i = 0; i < 4; i++)
                                            {
                                                 
                                                Console.Write(" Ingrese temperatura máxima para la habitacion "+(i+1)+" : ");
                                                temperaturamax[i] = Convert.ToDouble(Console.ReadLine());

                                                while (temperaturamax[i] < 18 || temperaturamax[i] > 35)
                                                {
                                                    Console.WriteLine(" No es posible configurar una temperatura mayor a 40 grados ni menor a 18. Inténtelo de nuevo.");
                                                    Console.Write(" Ingrese temperatura máxima para la habitación "+(i+1)+" : ");
                                                    temperaturamax[i] = Convert.ToDouble(Console.ReadLine());
                                                }

                                                if (temperaturamax[i] == 22)
                                                {
                                                    Console.WriteLine(" Ha ingresado una temperatura ideal");
                                                    
                                                }
                                               
                                            }

                                            Console.WriteLine(" Ha finalizado la configuración de temperaturas máximas y mínimas\n");
                                            Console.WriteLine(" Ingreso de temperaturas EXITOSO");
                                        }
                                                             
                                        break;
                                    case 3:
                                        {
                                            //PROMEDIO DE TEMPERATURAS
                                            Console.WriteLine("\n ***Accedió a la configuración del promedio de temperaturas***");
                                            a1 = 0;
                                            a2 = 0;
                                            //Sumatoria de todas las temperaturas ingresadas en la opción 2
                                            for (int i = 0; i < 4; i++)
                                            {
                                                a1 = a1 + temperaturamin[i];
                                                a2 = a2 + temperaturamax[i];
                                            }   
                                            double promediomin = a1 / 4;
                                            double promediomax = a2 / 4;

                                            //Si el usuario nunca ingresó alguna temperatura, el promedio será 0. 
                                            //Si el usuario si ingresó a la opción 2, se mostrará la temperatura

                                            if (promediomin == 0)
                                            {
                                                Console.WriteLine(" No se ha configurado las temperaturas mínimas");
                                            }
                                            else
                                            {

                                                Console.WriteLine(" Promedio de temperaturas mínimas " + promediomin);
                                            }
                                            if (promediomax == 0)
                                            {
                                                Console.WriteLine(" No se ha configurado las temperaturas máximas \n");
                                            }
                                            else
                                            {

                                                Console.WriteLine(" Promedio de temperaturas máximas " + promediomax + "\n");
                                            }                                                                                          
                                          
                                                
                                        }
                                
                                        break;
                                    case 4:
                                        break;
                                }
                            }                          

                        }
                        break;
                    case 5:
                        {
                            //Fin de la automatización
                            Console.WriteLine("Su configuración ha finalizado.");
                            Console.WriteLine("Automatización exitosa");

                        }
                        return;
                                 
                }
            }
            Console.ReadKey();
        }        
    }
}

