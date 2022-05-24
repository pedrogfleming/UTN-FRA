using System;

namespace _14_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
            //cálculo del área que corresponda:
            //a. double CalcularCuadrado(double)
            //b. double CalcularTriangulo(double, double)
            //c. double CalcularCirculo(double)
            //El ingreso de los datos como la visualización se deberán realizar desde el método Main().

            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;
            Console.WriteLine("Ingrese medida de un lado del cuadrado para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out ladoCuadrado))
            {
                Console.WriteLine("ERROR, vuelva a ingresar lado del cuadrado");
            }
            Console.WriteLine("Ingrese base del triangulo para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.WriteLine("ERROR, vuelva a ingresar base del triangulo");
            }
            Console.WriteLine("Ingrese altura del triangulo para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out alturaTriangulo))
            {
                Console.WriteLine("ERROR, vuelva a ingresar altura del triangulo");
            }
            Console.WriteLine("Ingrese radio del circulo para sacar el area");
            while (!double.TryParse(Console.ReadLine(), out radioCirculo))
            {
                Console.WriteLine("ERROR, vuelva a ingresar radio del circulo");
            }
            Console.WriteLine("El area del cuadrado es: {0}\n" +
                "El area del triangulo es: {1}\n" +
                "El area del circulo es: {2}\n", CalculoDeArea.CalcularCuadrado(ladoCuadrado),
                CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo),
                CalculoDeArea.CalcularCirculo(radioCirculo));
            Console.ReadKey();

            

        }
    }
}
