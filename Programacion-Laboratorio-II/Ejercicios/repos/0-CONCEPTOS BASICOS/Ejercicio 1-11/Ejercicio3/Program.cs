using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario 
                por consola.
                Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%) 
             */
            int numeroIngresado;
            int divisibleAux = 0;
            Console.WriteLine("Ingrese un número");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.WriteLine("ERROR, vuelva a ingresar el numero");
            }//FIN WHILE
            Console.WriteLine("Los numeros primos hasta el numero {0} son:\n", numeroIngresado);
            for (int i=2;i<numeroIngresado;i++ )
            {
                divisibleAux = 0;
                for (int j=1;j<=i;j++)            //cuento los divisores
                {
                    if((i%j) == 0)      
                    {
                        divisibleAux++;                        
                    }
                }//FIN FOR j
                if(divisibleAux == 2)           //Solo SI hay dos divisores, es numero primo
                {
                    Console.WriteLine("\n {0}", i);
                }                
                

            }//FIN FOR i            
            Console.ReadKey();
            
        }
    }
}
