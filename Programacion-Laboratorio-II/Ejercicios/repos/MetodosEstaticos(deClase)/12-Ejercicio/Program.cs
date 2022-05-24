using System;

namespace _12_Ejercicio
{
    class Program
    {
        /* Realizar un programa que sume números enteros hasta que el usuario lo determine,por medio de un mensaje "¿Continuar? (S/N)".
        En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de  opciones.
        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.        
         */
        static void Main(string[] args)
        {
            int numeroIngresado;
            int sumaNumerica = 0;
            char respuestaUsuario;            
            do
            {
                Console.WriteLine("Ingresar un numero");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("ERROR, vuelva a ingresar un numero");
                }
                Console.WriteLine("¿Continuar? (S/N)");
                while (!char.TryParse(Console.ReadLine(), out respuestaUsuario))
                {
                    Console.WriteLine("ERROR, vuelva a ingresar una letra de comando");
                }
                sumaNumerica = sumaNumerica + numeroIngresado;
            }while(ValidarRespuesta.ValidaS_N(respuestaUsuario) == true);
            Console.WriteLine("La suma de los numeros da {0}",sumaNumerica);
            Console.ReadKey();
        }
    }
}
