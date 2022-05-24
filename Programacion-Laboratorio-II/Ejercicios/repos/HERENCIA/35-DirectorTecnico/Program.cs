using System;

namespace _35_DirectorTecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(38555448, "Juan", 2, 10);
            Jugador j2 = new Jugador(37885465, "Lucas", 10, 3);
            Jugador j3 = new Jugador(36998524, "Pablo", 4, 7);

            Equipo e = new Equipo(2, "Pablonoentra");

            if (e + j1)
            {
                Console.WriteLine("Nuevo Jugador: " + j1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar el jugador");
            }

            if (e + j2)
            {
                Console.WriteLine("Nuevo Jugador: " + j2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar el jugador");
            }

            if (e + j3)
            {
                Console.WriteLine("Nuevo Jugador: " + j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar el jugador");
            }

            if (e + j1)
            {
                Console.WriteLine("Nuevo Jugador: " + j1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar el jugador");
            }

            Console.ReadKey();
        }
    }
}
