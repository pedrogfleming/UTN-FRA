using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ConversorBinario
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un número de entero a binario.
        /// </summary>
        /// <param name="decimalRecibido"></param>
        /// <returns></returns>
        public static string DecimalBinario(int decimalRecibido)
        {
            StringBuilder auxStringBuilder = new StringBuilder();
            int i = 0;
            do
            {
                if ((decimalRecibido % 2) == 0)
                {
                    //auxStringBuilder.Append('0');
                    auxStringBuilder.Insert(0, '0');
                }
                else
                {
                    //auxStringBuilder.Append('1');
                    auxStringBuilder.Insert(0, '1');
                }
                i++;
                decimalRecibido = decimalRecibido / 2;
            } while (decimalRecibido > 0);

            return auxStringBuilder.ToString();
        }        
        /// <summary>
        /// Convierte un número binario a entero.
        /// </summary>
        /// <param name="binarioRecibido"></param>
        /// <returns></returns>
        public static int BinarioDecimal(string binarioRecibido) //101
        {

            double auxPotencias = binarioRecibido.Length - 1; //las potencias q manejo
            double auxDigito;
            double ret = 0;
            string auxString;
            foreach (char letra in binarioRecibido)
            {
                auxString = letra.ToString();
                double.TryParse(auxString, out auxDigito);
                ret += (auxDigito * Math.Pow(2, auxPotencias));
                auxPotencias--;
            }

            return (int)ret;
        }


    }
}
