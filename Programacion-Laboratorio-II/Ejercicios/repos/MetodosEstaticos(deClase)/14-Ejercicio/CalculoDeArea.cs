using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Ejercicio
{
    public class CalculoDeArea
    {
        //Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
        //cálculo del área que corresponda:
        //a. double CalcularCuadrado(double)
        //b. double CalcularTriangulo(double, double)
        //c. double CalcularCirculo(double)
        //El ingreso de los datos como la visualización se deberán realizar desde el método Main().
        public static double CalcularCuadrado(double ladoCuadrado)
        {
           return Math.Pow(ladoCuadrado, 2);            
        }
        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo*alturaTriangulo)/2;
        }
        public static double CalcularCirculo(double radioCirculo)
        {
            return Math.PI * Math.Pow(radioCirculo, 2);
        }
    }
}
