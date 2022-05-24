using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _22_ConversorBinario;

namespace _22_ConversorBinario
{
    public class NumeroBinario
    {
        /*NumeroBinario:
            i. único atributo número (string)
            ii. único constructor privado (recibe un parámetro de tipo string)
         */
        public string numero;
        private NumeroBinario(string nB)
        {
            this.numero = nB;
        }
        public static implicit operator NumeroBinario(string nB)
        {
            return new NumeroBinario(nB); //NumeroBinario= "1001";
        }
        public static implicit operator string(NumeroBinario nB)
        {
            return nB.numero; 
        }
        #region SOBRECARGA BINARIO>>>DECIMAL
        public static explicit operator NumeroDecimal(NumeroBinario nB)
        {
            return Conversor.BinarioDecimal(nB); //NumeroBinario= "1001";
        }
        #endregion

        //i. string + (NumeroBinario, NumeroDecimal)
        //    ii. string - (NumeroBinario, NumeroDecimal)
        //    iii. bool == (NumeroBinario, NumeroDecimal)
        //    iv. bool != (NumeroBinario, NumeroDecimal)
        #region SOBRECARGA -
        public static string operator -(NumeroBinario nB, NumeroDecimal nD)
        {
            //int auxInt = Conversor.BinarioDecimal(nB.numero);
            //string resultado = Conversor.DecimalBinario(auxInt - (int)nD.numero);
            //return new NumeroBinario(resultado);
            //return Conversor.DecimalBinario(Conversor.BinarioDecimal(nB.numero) - (int)nD.numero);
            return Conversor.DecimalBinario(Conversor.BinarioDecimal(nB - (int)nD));
        }

        #endregion
        #region SOBRECARGA +
        public static string operator +(NumeroBinario nB, NumeroDecimal nD)
        {
            //int auxInt = Conversor.BinarioDecimal(nB.numero);
            //string resultado = Conversor.DecimalBinario(auxInt + (int)nD.numero);
            //return new NumeroBinario(resultado);
            //return Conversor.DecimalBinario(Conversor.BinarioDecimal(nB.numero) + (int)nD.numero);
            return Conversor.DecimalBinario(Conversor.BinarioDecimal(nB) + (int)nD);
        }

        #endregion
        #region SOBRECARGAR == !=
        public static bool operator ==(NumeroBinario nB, NumeroDecimal nD)
        {
            //return Conversor.BinarioDecimal(nB.numero) == (int)nD.numero;
            return Conversor.BinarioDecimal(nB) == ((int)nD);
        }
        public static bool operator !=(NumeroBinario nB, NumeroDecimal nD)
        {
            return !(nB == nD);
        }
        #endregion



    }
}
