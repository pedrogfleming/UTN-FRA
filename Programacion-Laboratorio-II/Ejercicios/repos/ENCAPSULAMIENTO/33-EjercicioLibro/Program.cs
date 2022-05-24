using System;

namespace _33_EjercicioLibro
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro SeñorDeLosAnillos = new Libro();

            SeñorDeLosAnillos[1] = "Frodo saludo a Sam";
            SeñorDeLosAnillos[2] = "Frodo robo el anillo";
            SeñorDeLosAnillos[3] = "Sam trato de escapar de los encantos de Frodo";
            //SeñorDeLosAnillos[0] = "Frodo saludo a Sam despues de haberlo mirado un rato a escondidas";
            SeñorDeLosAnillos[-4] = "El verdadero heroe fue Boromir y Aragorn le robo el trono";
            SeñorDeLosAnillos[6] = "Gandalf combatio a Saruman porque envidiaba su pelazo";
            for (int i = 0; i < SeñorDeLosAnillos.TotalPaginas(); i++)
            {
                Console.WriteLine("En la pagina {0} se lee lo siguiente: {1}", i, SeñorDeLosAnillos[i]);
            }
            Console.ReadKey();
        }
    }
}
