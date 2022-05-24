using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetin
{
    public class Euro
    {
        private static double cotizRespectoDolar;
        private double cantidad;
        #region Constructores
        static Euro()
        {
            cotizRespectoDolar = 1/1.08;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        //public static bool operator nombre Tipo()       

        #region Euro>>>Dolar & Euro>>>Pesos
        public static explicit operator Dolar(Euro d)
        {
            return new Dolar(d.cantidad / Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro d)
        {
            //return new Pesos(d.cantidad / Euro.GetCotizacion());
            return (Pesos)((Dolar)d);
        }
        #endregion
        #region Euro == Dolar
        public static bool operator == (Euro d, Dolar e)
        {
            if (d.cantidad == ((Euro)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Euro d, Dolar e)
        {
            return !(d == e);
        }

        #endregion
        #region Euro == Pesos
        public static bool operator == (Euro d, Pesos e)
        {
            if (d.cantidad == ((Euro)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Euro d, Pesos e)
        {
            return !(d == e);
        }
        #endregion
        #region Euro == Euro
        public static bool operator ==(Euro d, Euro e)
        {
            if (d.cantidad == e.GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Euro d, Euro e)
        {
            return !(d == e);
        }
        #endregion
        #region Sobrecarga -
        public static Euro operator -(Euro d, Dolar e)
        {
            return new Euro(d.cantidad - ((Euro)e).cantidad);
        }
        public static Euro operator -(Euro d, Pesos e)
        {
            return new Euro(d.cantidad - ((Euro)e).cantidad);
        }
        #endregion
        #region Sobrecarga +
        public static Euro operator +(Euro d, Dolar e)
        {
            return new Euro(d.cantidad + ((Euro)e).cantidad);
        }
        public static Euro operator +(Euro d, Pesos e)
        {
            return new Euro(d.cantidad + ((Euro)e).cantidad);
        }
        #endregion


    }

}
