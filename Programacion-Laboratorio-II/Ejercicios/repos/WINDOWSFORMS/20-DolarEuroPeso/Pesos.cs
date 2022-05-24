using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetin
{
    public class Pesos
    {
        
        #region Consigna
        //20. Generar un nuevo proyecto del tipo Console Application.Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dólar.
        //a.Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,08 dólares y 1 dólar equivale a 66 pesos.
        //b.El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
        //c.Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.
        //d.Colocar dentro del Main el código necesario para probar todos los métodos.
        //e.Los constructores estáticos le darán una cotización respecto del dólar por defecto a las clases.
        //f.Los comparadores == compararan cantidades.
        //g.Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido.
        //Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.
        //h.Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.
        #endregion
        private static double cotizRespectoDolar;
        private double cantidad;
        #region Constructores
        static Pesos()
        {
            cotizRespectoDolar = 66;
        }
        public Pesos(double cantidad)
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
        public static void SetCotizacion(double c)
        {
            cotizRespectoDolar = c;
        }
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        //public static bool operator nombre Tipo()     

        #region Pesos>>>Euro & Pesos>>>Dolar
        public static explicit operator Euro(Pesos d)
        {
            //return new Euro(d.cantidad / Euro.GetCotizacion());

            return (Euro)(Dolar)d; // De esta manera re utilizamos las conversiones explicitas, tomamos el peso, lo convertimos a Dolar y el resultado de este a Euro
        }
        public static explicit operator Dolar(Pesos d)
        {
            //return new Dolar(d.cantidad / Pesos.cotizRespectoDolar);
            //return (Pesos)((Dolar)d);
            return new Dolar(d.cantidad / Pesos.cotizRespectoDolar);
        }
        #endregion
        #region Pesos == Euro
        public static bool operator ==(Pesos d, Euro e)
        {
            if (d.cantidad == ((Pesos)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Pesos d, Euro e)
        {
            return !(d == e);
        }

        #endregion
        #region Pesos == Dolar
        public static bool operator ==(Pesos d, Dolar e)
        {
            if (d.cantidad == ((Pesos)e).GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Pesos d, Dolar e)
        {
            return !(d == e);
        }
        #endregion
        #region Pesos == Pesos
        public static bool operator ==(Pesos d, Pesos e)
        {
            if (d.cantidad == e.cantidad)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Pesos d, Pesos e)
        {            
            return !(d == e);
        }
        #endregion
        #region Sobrecarga -
        public static Pesos operator -(Pesos d, Euro e)
        {
            return new Pesos(d.cantidad - ((Pesos)e).cantidad);
        }
        public static Pesos operator -(Pesos d, Dolar e)
        {
            return new Pesos(d.cantidad - ((Pesos)e).cantidad);
        }
        #endregion
        #region Sobrecarga +
        public static Pesos operator +(Pesos d, Euro e)
        {
            return new Pesos(d.cantidad + ((Pesos)e).cantidad);
        }
        public static Pesos operator +(Pesos d, Pesos e)
        {
            return new Pesos(d.cantidad + ((Pesos)e).cantidad);
        }
        #endregion
    }
}
