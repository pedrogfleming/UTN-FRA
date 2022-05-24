using System;
using Entidades;
namespace _19_Sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            /*19. Realizar una aplicación de consola. Agregar la clase Sumador.
            a. Crear dos constructores:
            i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
            ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
            b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
            siguiente lógica:
            i. En el caso de Sumar(long, long) sumará los valores numéricos
            ii. En el de Sumar(string, string) concatenará las cadenas de texto.
            Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
            c. Generar una conversión explícita que retorne cantidadSumas.
            d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
            con dicho valor.
            e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
            cantidadSumas.
            Agregar un segundo objeto del tipo Sumador en el Main y probar el código.
             */
            #endregion
            Sumador miCuenta = new Sumador();
            Sumador miCuenta2 = new Sumador();
            Console.WriteLine("Cantidad de sumas {0}", (int)miCuenta);
            long resultadoEntero = miCuenta.Sumar(2, 4);
            Console.WriteLine("Cantidad de sumas {0}", (int)miCuenta);
            Console.WriteLine("La suma de los long da {0}", resultadoEntero);
            string resultadoConcatenacion = miCuenta.Sumar("a", "z");
            Console.WriteLine("La suma de los strings da {0}", resultadoConcatenacion);
            Console.WriteLine("Cantidad de sumas {0}", (int)miCuenta);
            Console.WriteLine("Sumados con casteo: {0}",(miCuenta + miCuenta2));
            Console.WriteLine("Son iguales: {0}", (miCuenta | miCuenta2));



            Console.ReadKey();

        }
    }
}
