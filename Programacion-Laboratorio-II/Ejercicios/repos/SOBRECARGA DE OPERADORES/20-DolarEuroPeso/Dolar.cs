using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetin
{
    public class Dolar
    {

        private static double cotizRespectoDolar;
        private double cantidad;
        #region Constructores
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #endregion

        #region Getters()
        public double GetCantidad()
        {
            return this.cantidad;
        }
        static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion


        /*
        public Dolar(double cantidad,double cotizacion)
        {
            cotizRespectoDolar = cotizacion;
            this.cantidad = cantidad;
        }
        */
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        //public static bool operator nombre Tipo()       
        public static implicit operator double(Dolar d)
        {
            return d.cantidad;
        }
        #region dolar>>>euro & dolar>>>peso
        public static  explicit operator Euro(Dolar d)
        {
            return new Euro(d* Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d * Pesos.GetCotizacion());
        }
        #endregion
        #region Dolar == Euro
        public static bool operator == (Dolar d, Euro e)
        {
            if (d == ((Dolar)e))
            {
                return true;
            }
            return false;
        }
        public static bool operator != (Dolar d,Euro e)
        {
            //if (d.cantidad == e.GetCantidad())
            //{
            //    return false;
            //}
            //return true;
            return !(d == e);
        }

        #endregion
        #region Dolar == Pesos
        public static bool operator ==(Dolar d, Pesos e)
        {
            if (d.cantidad == ((Dolar)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Dolar d, Pesos e)
        {
            //if (d.cantidad == e.GetCantidad())
            //{
            //    return false;
            //}
            //return true;
            return !(d == e);
        }
        #endregion
        #region Dolar == Dolar
        public static bool operator == (Dolar d, Dolar e)
        {
            if (d.cantidad == e.cantidad)
            {
                return true;
            }
            return false;
        }
        public static bool operator != (Dolar d, Dolar e)
        {            
            return !(d == e);
        }
        #endregion
        #region Sobrecarga -
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar (d.cantidad - ((Dolar)e).cantidad);
        }
        public static Dolar operator -(Dolar d, Pesos e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }
        #endregion
        #region Sobrecarga +
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }
        public static Dolar operator +(Dolar d, Pesos e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }
        #endregion


    }
}
