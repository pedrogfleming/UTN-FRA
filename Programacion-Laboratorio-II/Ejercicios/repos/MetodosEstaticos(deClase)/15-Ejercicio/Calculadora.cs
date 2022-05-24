using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Ejercicio
{
    public class Calculadora
    {
        //Realizar un programa que permita realizar operaciones matemáticas simples
        //(suma, resta,multiplicación y división).
        //Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar(pulsando el caracter +, -, *o /).
        //El usuario decidirá cuándo finalizar el programa.
        
        //Crear una clase llamada Calculadora que posea dos métodos estáticos(de clase):
        //a.Calcular(público): Recibirá tres parámetros:
        //el primer número,
        //el segundo número y la operación matemática.El método devolverá el resultado de la operación.
        //b.Validar(privado): Recibirá como parámetro el segundo número.
        //Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
        //Este método devolverá TRUE si el número es distinto de CERO.
        public static float Calcular(int primerNumero,int segundoNumero,char operacion)
        {
            float resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = (float)primerNumero * segundoNumero;
                    break;
                case '/': 
                     if(!Validar(segundoNumero))
                    {
                        return resultado;
                    }
                    resultado = (float)primerNumero / segundoNumero;
                    break;
                default:
               break;
            }//FIN SWITCH
            return resultado;
        }
        private static bool Validar(int numeroEntero)
        {
            if(numeroEntero != 0)
            {
                return true;
            }
            return false;
        }

    }
}
