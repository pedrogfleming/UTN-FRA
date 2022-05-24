using System;

/*Ingresar un número y mostrar:
 * el cuadrado y el cubo del mismo.
 * Se debe validar que el número sea mayor que cero
 * caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
    Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. 
 * 
 */

namespace ejercicoDos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroIngresado;
            double cuadradoNumero;
            double cuboNumero;
            Console.WriteLine("Ingresar numero(debe ser mayor a cero):");
            while (!double.TryParse(Console.ReadLine(), out numeroIngresado) || numeroIngresado <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }//FIN WHILE
            cuadradoNumero = Math.Pow(numeroIngresado, 2);
            cuboNumero = Math.Pow(numeroIngresado, 3);
            Console.WriteLine("El número ingresado es: \n {0,-10} " +
                "\nEl cuadrado del numero es: {1,-10} " +
                "\nEl cubo del numero es {2,-10}", numeroIngresado, cuadradoNumero, cuboNumero);
            Console.ReadKey();
        }
    }
}
