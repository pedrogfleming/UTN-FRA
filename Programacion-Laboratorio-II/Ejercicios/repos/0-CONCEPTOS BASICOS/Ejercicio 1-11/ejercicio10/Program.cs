using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10. Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
                una pirámide como la siguiente:                                
                Nota: Utilizar estructuras repetitivas y selectivas.
             * 
             */
            int alturaPiramide;
            Console.WriteLine("Indique altura de la piramide");
            while (!int.TryParse(Console.ReadLine(), out alturaPiramide) || alturaPiramide < 1)
            {
                Console.WriteLine("Error, Indique altura de la piramide válida");
            }
            for (int i = 0; i < alturaPiramide; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("**");
                }

                Console.WriteLine("*");
            }
            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
