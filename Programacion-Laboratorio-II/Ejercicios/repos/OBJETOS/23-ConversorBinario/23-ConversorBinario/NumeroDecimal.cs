using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ConversorBinario
{
    public class NumeroDecimal
    {
        /*b. NumeroDecimal
            i. único atributo número (double)
            ii. único constructor privado (recibe un parámetro de tipo double)
         * 
         */
        public double numero;
        NumeroDecimal(double d)
        {
            this.numero = d;
        }
        public static implicit operator NumeroDecimal(double d)
        {
            return new NumeroDecimal(d);
        }
        public static implicit operator double(NumeroDecimal d)
        {
             return d.numero;
        }
        #region SOBRECARGA DECIMAL>>>BINARIO
        public static explicit operator NumeroBinario(NumeroDecimal nD)
        {
            return (Conversor.DecimalBinario((int)nD));
        }
        #endregion
        #region SOBRECARGA -
        public static NumeroDecimal operator -(NumeroDecimal a, NumeroDecimal b)
        {
            return new NumeroDecimal(a.numero-b.numero);
        }
        public static double operator -(NumeroDecimal nD,NumeroBinario nB)
        {
            //int auxInt = Conversor.BinarioDecimal(nB.numero);
            //string resultado = Conversor.DecimalBinario(auxInt - (int)nD.numero);
            //return new NumeroBinario(resultado);
            //return Conversor.BinarioDecimal(nB.numero) - (int)nD.numero;
            return Conversor.BinarioDecimal(nB) - (int)nD;
        } 
        #endregion
        #region SOBRECARGA +
        public static double operator +(NumeroDecimal nD,NumeroBinario nB)
        {
            //int auxInt = Conversor.BinarioDecimal(nB.numero);
            //string resultado = Conversor.DecimalBinario(auxInt + (int)nD.numero);
            //return new NumeroBinario(resultado);
            //return (Conversor.BinarioDecimal(nB.numero) + (int)nD.numero);
            return Conversor.BinarioDecimal(nB) + (int)nD;
        }
        #endregion
        #region SOBRECARGA == !=
        public static bool operator ==(NumeroDecimal nD, NumeroBinario nB)
        {
            //return Conversor.BinarioDecimal(nB.numero) == (int)nD.numero;
            return Conversor.BinarioDecimal(nB) == (int)nD;
        }
        public static bool operator !=(NumeroDecimal nD, NumeroBinario nB)
        {
            return !(nB == nD);
        }
        #endregion
    }
}
