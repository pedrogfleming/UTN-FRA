using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

#region Consigna
/* Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
    string DecimalBinario(int). Convierte un número de entero a binario.
    int BinarioDecimal(string). Convierte un número binario a entero.
    NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
 */
#endregion


namespace _13_Ejercicio
{
    public class Conversor
    {
        //Convierte un número de entero a binario.
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
                    auxStringBuilder.Insert(0,'1');
                }
                i++;
                decimalRecibido = decimalRecibido/2;
            }while(decimalRecibido > 0);
            
            return auxStringBuilder.ToString();
        }
        //Convierte un número binario a entero.
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
                ret += (auxDigito*Math.Pow(2,auxPotencias));
                auxPotencias--;
            }

            return (int)ret;
        }
    #region codigo mio
                //for (int i = binarioRecibido.Length; i > 0; i--)
                //{

                //    //string auxString;
                //    //int auxBinario;
                //    //char[] auxChar; 
                //    ////binarioRecibido.CopyTo(0,auxStri+ng,0, binarioRecibido.Length);
                //    //auxString = (string)binarioRecibido.Clone();
                //    //for(i=binarioRecibido.Length;i>0;i--)
                //    //{
                //    //    binarioRecibido.CopyTo(i,auxChar[],i,binarioRecibido.Length);
                //    //    auxBinario = (int)auxChar[];
                //    //}


                //}
                #endregion
}
    #region Manejo de String
    //Random rnd = new Random();
    //StringBuilder sb = new StringBuilder();
    //StreamWriter sw = new StreamWriter(@".\StringFile.txt",
    //                                   false, Encoding.Unicode);
    //for (int ctr = 0; ctr <= 1000; ctr++)
    //{
    //    sb.Append((char)rnd.Next(1, 0x0530));
    //    if (sb.Length % 60 == 0)
    //        sb.AppendLine();
    //}
    //sw.Write(sb.ToString());
    //sw.Close();
    //string aux;
    //string aux = 0;
    #endregion
}
