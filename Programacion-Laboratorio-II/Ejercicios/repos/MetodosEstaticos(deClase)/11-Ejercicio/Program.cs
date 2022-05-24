using System;
namespace _11_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la siguiente firma:
            //bool Validar(int valor, int min, int max):
            //a.valor: dato a validar
            //b.min y max: rango en el cual deberá estar la variable valor.
            //Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
            //anteriormente que estén dentro del rango - 100 y 100.
            //Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            //Nota: Utilizar variables escalares, NO utilizar vectores.
            int numeroIngresado;
            int min = int.MaxValue;
            int max = int.MinValue;
            int totalNumeros = 10;
            int sumaNumerica = 0;
            float promedio;
            Console.WriteLine("Ingrese un numero");
            for (int i = 0; i < totalNumeros; i++)
            {
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                    {
                        Console.WriteLine("ERROR, vuelva a ingresar un numero");
                    }
                }while(Validacion.Validar(numeroIngresado, -100, 100) == false);
                if(numeroIngresado < min)
                {
                    min = numeroIngresado;
                }
                if(numeroIngresado > max)
                {
                    max = numeroIngresado;
                }
                sumaNumerica = sumaNumerica + numeroIngresado;
            }//FIN FOR
            promedio = sumaNumerica /(float)totalNumeros;
            Console.WriteLine("El menor de los numeros es {0} \nEl mayor de {1} \n El promedio es {2:#,##.00}",min,max,promedio);
            Console.ReadKey();
        }
    }
}
