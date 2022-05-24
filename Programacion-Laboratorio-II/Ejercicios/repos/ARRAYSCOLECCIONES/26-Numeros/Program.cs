using System;
using System.Collections.Generic;

namespace _26_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna ej26
            //26.Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos) distintos de
            //cero de forma aleatoria utilizando la clase Random.
            //a.Mostrar el vector tal como fue ingresado
            //b.Luego mostrar los positivos ordenados en forma decreciente.
            //c.Por último, mostrar los negativos ordenados en forma creciente.
            //27.Realizar el ejercicio anterior pero esta vez con las siguientes colecciones:
            //Pilas, Colas y Listas.
            #endregion
            //int numeroIngresado;
            //SortedList<int, int> listadoOrdenadoNumerico;

            #region SortedList
            //SortedList listadoOrdenadoNumerico = new SortedList();
            //SortedList<int, int> listadoOrdenadoNumerico;

            //Random auxR = new Random();
            //numeroIngresado = auxR.Next(Int32.MinValue, Int32.MaxValue);
            //listadoOrdenadoNumerico.Add(numeroIngresado);


            #endregion
            int auxInt;
            Queue <int> listadoNumerico = new Queue<int>();
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese numero");
                while(!int.TryParse(Console.ReadLine(),out auxInt))
                {
                    Console.WriteLine("Error,reingrese numero");
                }
                listadoNumerico.Enqueue(auxInt);
            }            
            foreach (int item in listadoNumerico)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();


        }

    }
}
