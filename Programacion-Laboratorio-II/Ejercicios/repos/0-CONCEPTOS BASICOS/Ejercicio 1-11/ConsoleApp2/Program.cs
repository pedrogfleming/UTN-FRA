using System;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 5;
            //string ingreso;
            int numeroIngresado;
            int numeroMayor = int.MinValue;
            int numeroMenor = int.MaxValue;
            int sumaNumeros = 0;
            float promedioFinal = 0;
            /*Ingresar 5 números por consola,
             * guardándolos en una variable escalar.
             * Luego calcular y mostrar:
             * el  valor máximo, el valor mínimo y el promedio             * 
             */
            for (int i = 0; i < totalNumeros; i++)
            {
                Console.WriteLine("Ingrese numero");
                //ingreso = Console.ReadLine();
                //if(int.TryParse(ingreso,out numeroIngresado))
                //{
                //}                
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("ERROR, vuelva a ingresar el numero");
                }//FIN WHILE
                if (numeroIngresado > numeroMayor)
                {
                    numeroMayor = numeroIngresado;
                }
                if (numeroIngresado < numeroMenor)
                {
                    numeroMenor = numeroIngresado;
                }                
                sumaNumeros = sumaNumeros+numeroIngresado;
            }//FIN FOR
            promedioFinal = sumaNumeros / (float)totalNumeros;
            Console.WriteLine("El promedio de los numeros es: \n {0,-3:#,###.00} \n el número mayor es {1,-3} \n el menor es {2,-3}", promedioFinal, numeroMayor, numeroMenor);
        }
    }
}
