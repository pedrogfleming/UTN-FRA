using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        //x  a.Es una clase sellada(sealed).
        //x  b.El campo porcentajeIva es estático.
        //x  c.Tiene un constructor estático que inicializará el campo porcentajeIva en 21. 
        //x d.El constructor de instancia sólo debe ser accesible desde el mismo ensamblado(assembly,.dll). Utilice el modificador de acceso que corresponda.
        //x  e.El constructor de instancia inicializará el campo producto y llamará al método Vender pasándole la cantidad indicada como argumento.
        //x  f.El método Vender es privado y de instancia.
        //x  i.Le restará al stock del producto la cantidad que le pasaron por parámetro. 
        //x ii.Inicializará el campo fecha con la fecha actual completa.
        //x  iii.Inicializará el campo precioFinal con el valor retornado por el método
        //  CalcularPrecioFinal, al cual se le pasará el precio unitario del producto y la cantidad.
        //x  g.El método CalcularPrecioFinal es estático y público.Calculará el precio final multiplicando
        //x  el precio unitario por la cantidad comprada y a este resultado le aplicará el porcentaje de
        //x  IVA que esté indicado en el campo porcentajeIva.
        //x  h.El método ObtenerDescripcionBreve devuelve un string breve y en una sola línea indicando
        //      fecha, descripción del producto y precio final. De esta forma: “fecha – descripción –precioFinal”.
        //      El precio deberá mostrarse con 2 decimales.
        //x     i.Tiene una propiedad que devuelve la fecha de la venta.
        //x      Es de sólo lectura y tiene el mismo modificador de acceso que el constructor de instancia

        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        static Venta()
        {
            porcentajeIva = 21;
        }
        internal Venta(Producto producto,int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        internal DateTime Fecha 
        {
            get
            {
                return this.fecha;
            }
        }
        /// <summary>
        /// El método Vender es privado y de instancia.
        ///i.Le restará al stock del producto la cantidad que le pasaron por parámetro. 
        ///ii.Inicializará el campo fecha con la fecha actual completa.
        ///iii.Inicializará el campo precioFinal con el valor retornado por el método
        /// </summary>
        /// <param name="cantidad"></param>
        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }
        /// <summary>
        /// CalcularPrecioFinal, al cual se le pasará el precio unitario del producto y la cantidad.
        ///g.El método CalcularPrecioFinal es estático y público.
        ///Calculará el precio final multiplicando el precio unitario por la cantidad comprada 
        ///y a este resultado le aplicará el porcentaje de IVA que esté indicado en el campo porcentajeIva.
        /// </summary>
        /// <param name="precioUnidad"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double aux = precioUnidad * cantidad;
            return aux * ((double)porcentajeIva / 100);
        }
        //h.El método ObtenerDescripcionBreve devuelve un string breve y en una sola línea indicando
        //fecha, descripción del producto y precio final.
        //De esta forma: “fecha – descripción –precioFinal”. El precio deberá mostrarse con 2 decimales.
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1} - {2:0.00}",this.Fecha,this.producto.Descripcion,this.precioFinal);
            return sb.ToString();
        }
    }
}
