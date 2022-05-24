using System;

namespace _22_ConversorBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tomando la clase Conversor del ejercicio 13, se pide:
            Agregar las clases:
            a. NumeroBinario:
            i. único atributo número (string)
            ii. único constructor privado (recibe un parámetro de tipo string)
            b. NumeroDecimal
            i. único atributo número (double)
            ii. único constructor privado (recibe un parámetro de tipo double)

            Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de operadores:

            c. NumeroBinario:
            i. string + (NumeroBinario, NumeroDecimal)
            ii. string - (NumeroBinario, NumeroDecimal)
            iii. bool == (NumeroBinario, NumeroDecimal)
            iv. bool != (NumeroBinario, NumeroDecimal)

            d. NumeroDecimal:
            i. double + (NumeroDecimal, NumeroBinario)
            ii. double - (NumeroDecimal, NumeroBinario)
            iii. bool == (NumeroDecimal, NumeroBinario)
            iv. bool != (NumeroDecimal, NumeroBinario)

            Agregar conversiones implícitas para poder ejecutar:

            e. NumeroBinario objBinario = "1001";
            f. NumeroDecimal objDecimal = 9;

            Agregar conversiones explícitas para poder ejecutar:

            g. (string)objBinario
            h. (double)objDecimal

            Generar el código en el Main para instanciar un objeto de cada tipo y operar entre ellos,imprimiendo cada resultado por pantalla.
             * 
             */

            NumeroBinario objBinario = "0001";
            NumeroDecimal objDecimal = 8;
            NumeroDecimal sumaResultadoDecimal;
            NumeroBinario sumaResultadoBinario;
            sumaResultadoDecimal = (NumeroDecimal)objBinario + objDecimal;
            sumaResultadoBinario = objBinario + (NumeroBinario)objDecimal;
            Console.WriteLine(Conversor.DecimalBinario(4));
            Console.WriteLine("La suma 1 es: {0}",sumaResultadoDecimal.numero);
            double resta = (NumeroDecimal)objBinario - objDecimal;

            Console.WriteLine("a respecto a b es : {0}", objBinario == objDecimal);
            Console.WriteLine("a+b en binario es : {0}", sumaResultadoBinario.numero);
            Console.WriteLine("a-b en decimal es {0}", resta);

            Console.ReadKey();
        }
    }
}
