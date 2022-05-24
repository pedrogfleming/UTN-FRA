using System;

namespace SobreescribiendoAdvertencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.MiMetodo());

            //string objeto = "¡Este es mi método ToString sobrescrito!";

            //Console.WriteLine("----------------------------------------------");
            //Console.Write("Comparación Sobrecargas con String: ");
            //Console.WriteLine(objetoSobrescrito.Equals(objeto));

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine(objetoSobrescrito.GetHashCode());



            Console.ReadKey();
        }
    }
}
