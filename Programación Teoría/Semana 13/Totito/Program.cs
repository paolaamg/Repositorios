using System;

class Program
{
    public static string[,] tablero = new string[3, 3];
    public static string jugador1, jugador2;

    //asigna que pieza tiene el jugador
    public static void asignarJugador(int numeroJugador, string pieza)
    {
        if (numeroJugador == 1)
        {
            jugador1 = pieza;
        }
        else
        {
            jugador2 = pieza;
        }

    }

    // inicializar mi tablero
    public static void iniciar()
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                tablero[f, c] = "";
            }
        }
    }

    public static void mostrar()
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(tablero[f, c] + " | ");
            }
            Console.WriteLine(); //enter
            Console.Write("____________\n");

        }
    }


    public static void jugar(string jugador, int fila, int columna)
    {
        if (fila > 2 || columna > 2)
        {
            Console.WriteLine("Posicion fuera del tablero");
            return;
        }


        if (tablero[fila, columna] == "")
        {
            tablero[fila, columna] = jugador;
        }
        else
        {
            Console.WriteLine("Posicion no valida");
        }

        evaluar();
    }

    public static void evaluar()
    {
        bool ocupado = false;
        //evaluar filas
        for (int f = 0; f < 3; f++)
        {
            ocupado = tablero[f, 0] == "x" || tablero[f, 0] == "o";

            if (ocupado == true && tablero[f, 0] == tablero[f, 1] && tablero[f, 1] == tablero[f, 2])
            {
                Console.WriteLine("gano " + tablero[f, 0]);
                break;
            }
        }
        //evaluar columnas
        for (int c = 0; c < 3; c++)
        {
            ocupado = tablero[0, c] == "x" || tablero[0, c] == "o";
            if (ocupado == true && tablero[0, c] == tablero[1, c] && tablero[1, c] == tablero[2, c])
            {
                Console.WriteLine("gano " + tablero[0, c]);
                break;
            }
        }

        ocupado = tablero[1, 1] == "x" || tablero[1, 1] == "o";

        if (ocupado == true && tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
        {
            Console.WriteLine("gano " + tablero[0, 0]);
        }

        if (ocupado == true && tablero[2, 0] == tablero[1, 1] && tablero[1, 1] == tablero[0, 2])
        {
            Console.WriteLine("gano " + tablero[2, 0]);
        }


    }


    public static void Main()
    {
        //prueba 0
        iniciar();
        mostrar();
        asignarJugador(1, "x");
        asignarJugador(2, "o");
        jugar("x", 0, 0);
        jugar("o", 0, 0); // prueba preventiva
        jugar("o", 1, 1);
        jugar("x", 0, 1);
        jugar("o", 2, 1);
        jugar("x", 0, 2);
        jugar("x", 3, 5); // prueba preventiva





        mostrar();

        Console.ReadKey();
    }
}
