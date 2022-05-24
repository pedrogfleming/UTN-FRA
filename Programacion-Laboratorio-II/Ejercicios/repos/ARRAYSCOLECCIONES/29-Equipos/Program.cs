using System;

namespace _29_Equipos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*29. Crear una Clase llamada Jugador y otra Equipo con la siguiente estructura:
             * Jugador:
            a. Todos los datos estadísticos del Jugador se inicializarán en 0 dentro del constructor privado.
            b. El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
            c. MostrarDatos retornará una cadena de string con todos los datos y estadística del Jugador.
            d. Dos jugadores serán iguales si tienen el mismo DNI.

            Equipo:
            e. La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
            f. La sobrecarga del operador + agregará jugadores a la lista siempre y cuando este no exista
            aun en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo
            cantidadDeJugadores.

            Generar los métodos en el Main para probar el código.
             */
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
