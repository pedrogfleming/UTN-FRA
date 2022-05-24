using System;

namespace _15_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que permita realizar operaciones matemáticas simples
            //(suma, resta,multiplicación y división).
            //Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar(pulsando el caracter +, -, *o /).
            //El usuario decidirá cuándo finalizar el programa.
            //Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):
            //a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la
            //operación matemática.El método devolverá el resultado de la operación.
            //b.Validar(privado): Recibirá como parámetro el segundo número. Este método se debe
            //utilizar sólo cuando la operación elegida sea la DIVISIÓN.Este método devolverá
            //TRUE si el número es distinto de CERO.
            int numeroA;
            int numeroB;
            char operacion;
            float resultado;
            Console.WriteLine("Ingrese primer numero");
            while (!int.TryParse(Console.ReadLine(), out numeroA))
            {
                Console.WriteLine("ERROR, vuelva a ingresar el primer numero");
            }
            Console.WriteLine("Ingrese segundp numero");
            while (!int.TryParse(Console.ReadLine(), out numeroB))
            {
                Console.WriteLine("ERROR, vuelva a ingresar el segundo numero");
            }
            Console.WriteLine("Ingrese operacion a realizar \n+SUMA\n-RESTA\n*Multiplicacion\n/Division");
            while (!char.TryParse(Console.ReadLine(), out operacion))
            {
                Console.WriteLine("ERROR, vuelva a ingresar operacion a realizar \n+SUMA\n-RESTA\n*Multiplicacion\n/Division");
            }
            resultado = Calculadora.Calcular(numeroA, numeroB, operacion);
            Console.WriteLine("Numero A[{0}] Numero B[{1}]\nOperacion a realizar[{2}]", numeroA, numeroB, operacion);
            if (operacion == '/' && resultado == 0)
            {
                Console.WriteLine("No se pudo realizar la division dado que no se puede dividir por cero");
            }
            else
            {
                Console.WriteLine("El resultado de la operacion es: {0}", resultado);
            }
            Console.ReadKey();
        }
    }
}
