using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que imprima por pantalla una pirámide como
            //la siguiente:
            //         *
            //        **
            //      ****
            //    ******
            //  ********
            //**********

            //El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo.Para el
            //ejemplo anterior la altura ingresada fue de 5.
            int alturaPiramide;
            Console.WriteLine("Indique altura de la piramide");
            while (!int.TryParse(Console.ReadLine(), out alturaPiramide) || alturaPiramide < 1)
            {
                Console.WriteLine("Error, Indique altura de la piramide válida");
            }
            for(int i=0;i< alturaPiramide;i++)
            {
                for(int j=1;j<= i; j++)
                {
                    /*
                     * 
                     */
                    Console.Write("**");

                  
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
            //Nota: Utilizar estructuras repetitivas y selectivas.

        }
    }
}
