using System;
using Geometria;
namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto v1 = new Punto(1, 1);
            Punto v3 = new Punto(4, 2);
            Rectangulo miRectangulo = new Rectangulo(v1, v3);
            //Rectangulo miRectangulo = new Rectangulo(new Punto(1, 1), new Punto(4, 2));
            miRectangulo.Mostrar();

            Console.ReadKey();

        }
    }
}
