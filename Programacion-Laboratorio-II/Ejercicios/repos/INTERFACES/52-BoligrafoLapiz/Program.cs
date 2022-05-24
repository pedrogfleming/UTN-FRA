using System;
using Entidades;
namespace _52_BoligrafoLapiz
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            Console.ReadKey();
            Cartuchera1 c1 = new Cartuchera1();
            c1 += miBoligrafo;
            c1 += miLapiz;

            while (c1.ProbarElementos())
            {
                Console.WriteLine(true);
            }
            Console.WriteLine(false);
            Console.ReadKey();
        }
    }
}
