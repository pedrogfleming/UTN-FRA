using System;

/* Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
    string DecimalBinario(int). Convierte un número de entero a binario.
    int BinarioDecimal(string). Convierte un número binario a entero.
    NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
 */
namespace _13_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string numeroConvertidoString;
            int binarioConvertido;
            Console.WriteLine("Ingrse un numero decimal para convertir a binario");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.WriteLine("ERROR, vuelva a ingresar un numero");
            }
            numeroConvertidoString = Conversor.DecimalBinario(numeroIngresado);
            Console.WriteLine("El numero {0} es el numero {1} en binario", numeroIngresado, numeroConvertidoString);
            binarioConvertido = Conversor.BinarioDecimal(numeroConvertidoString);
            Console.WriteLine("el binario quedo{0}", binarioConvertido);
            Console.ReadKey();
        }
    }
}
