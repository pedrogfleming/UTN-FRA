using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    public class BisiestoAnual
    {
        public static int ContarBisiestos(DateTime fechaInicial, DateTime fechaFinal)
        {
            int contadorBisiestos = 0;
            for (int i = fechaInicial.Year; i < fechaFinal.Year; i++)
            {

                if ((i % 4) != 0)
                {
                    continue;
                }
                else //Un año es bisiesto si es múltiplo de 4. 
                {
                    if ((i % 100) == 0)
                    {
                        if ((i % 400) == 0)       //Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
                        {
                            //Console.WriteLine("El año {0} es bisiesto", i);
                            contadorBisiestos++;
                        }
                        continue;
                    }
                    else
                    {
                        //Console.WriteLine("El año {0} es bisiesto", i);
                        contadorBisiestos++;
                    }
                }

            }//FIN FOR
            return contadorBisiestos;
        }
    }
}
