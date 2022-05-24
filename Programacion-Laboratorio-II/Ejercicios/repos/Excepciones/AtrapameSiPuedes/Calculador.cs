using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtrapameSiPuedes
{
    public static class Calculador
    {
        static Calculador()
        {
        }
        public static double Calcular(int a, int b)
        {
            try
            {
                return ((double)a / b);
            }
            catch (DivideByZeroException e)
            {

                throw new Exception("Intento de division por cero, cancelada la operacion",e);
            }
            
        }
    }
}
