using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        //x  a.El constructor instanciará los campos de tipo List.
        //x  b.Tendrá un indexador que recibirá como parámetro un código Guid y devolverá el producto
        //     de la lista de productos que corresponda con ese código.Si no encuentra ningún producto devolverá null. 
        //x  c.La sobrecarga del operador == debe verificar si el producto se encuentra en la lista de
        //  productos comparando la descripción.Si dos productos tienen la misma descripción son elmismo producto.
        //x  d.La sobrecarga del operador != debe reutilizar código, no repetir. 
        //x  e.La sobrecarga del operador + debe agregar un producto a la lista de producto
        //      siempre que el mismo ya no exista en la lista.
        //x  f.El método Vender agrega una nueva venta a la lista de ventas. 
        //x  g.El método Vender tiene una sobrecarga que sólo recibe un producto (sin cantidad). Llamará
        //x    a la sobrecarga más compleja pasándole como argumento a la cantidad el valor de 1. 
        //x     h.ListarVentas devuelve un string conteniendo la descripción breve de cada venta en la lista
        //      de ventas.Una descripción por línea. Utilizar las herramientas que expone la clase Venta. 
        //      La lista deberá estar ordenada por fecha de la más reciente a la más antigua (Para
        //      esto utilice el mecanismo que conozca y prefiera. Si lo necesita, agregue un método extra o
        //      lo que requiera).
        //x      i.ListarProductos devuelve un Dictionary<Guid, string>.Cada elemento del diccionario
        //      corresponderá con cada producto en la lista de productos. La key será el código del
        //      producto y el valor la descripción del producto.

        private List<Producto> productos;
        private List<Venta> ventas;

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        #region Indexador Guid
        /// <summary>
        /// b.Tendrá un indexador que recibirá como parámetro un código Guid y devolverá el producto
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto item in this.productos)
                {
                    if (((Guid)item) == codigo)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
        #endregion
        #region Metodos Vender
        /// <summary>
        /// f.El método Vender agrega una nueva venta a la lista de ventas.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        /// <summary>
        /// g.El método Vender tiene una sobrecarga que sólo recibe un producto(sin cantidad). Llamará
        /// a la sobrecarga más compleja pasándole como argumento a la cantidad el valor de 1. 
        /// </summary>
        /// <param name="producto"></param>
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        #endregion
        #region Listar Productos
        /// <summary>
        /// i.ListarProductos devuelve un Dictionary<Guid, string>.
        /// Cada elemento del diccionario corresponderá con cada producto en la lista de productos
        /// La key será el código del producto y el valor la descripción del producto.
        /// </summary>
        /// <returns></returns>
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> auxList = new Dictionary<Guid, string>();
            foreach (Producto item in this.productos)
            {
                auxList.Add(((Guid)item), item.Descripcion);
            }
            return auxList;
        }
        #endregion
        #region Listar Ventas Metodos
        /// <summary>
        /// //h.ListarVentas devuelve un string conteniendo la descripción breve de cada venta en la lista de ventas.
        ///Una descripción por línea.
        ///Utilizar las herramientas que expone la clase Venta. 
        /// </summary>
        /// <returns></returns>
        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            List<Venta> auxLista = ordernarPorFechaReciente(this.ventas);
            foreach (Venta item in this.ventas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// La lista deberá estar ordenada por fecha de la más reciente a la más antigua
        ///(Para esto utilice el mecanismo que conozca y prefiera.
        ///Si lo necesita, agregue un método extra o lo que requiera).
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <returns></returns>
        private static List<Venta> ordernarPorFechaReciente(List<Venta> listaVentas)
        {
            //List<Venta> auxLista = new List<Venta>();
            List<Venta> auxLista = listaVentas.OrderByDescending(x => x.Fecha).ToList();
            listaVentas.Sort(OrdenarPorFecha);
            //List<Venta> auxLista = listaVentas.OrderByDescending(OrdenarPorFecha).ToList();
            //foreach (Venta item in listaVentas)
            //{
            //    foreach (Venta auxIt in listaVentas)
            //    {
            //        if (item.Fecha > auxIt.Fecha)
            //        {
            //            auxLista.Add(auxIt);
            //            break;
            //        }
            //        if (item.Fecha < auxIt.Fecha)
            //        {
            //            auxLista.Add(item);
            //        }
            //        break;
            //    }
            //}
            return auxLista;
        }

        internal static int OrdenarPorFecha(Venta a,Venta b)
        {
            if (a.Fecha > b.Fecha)
            {
                return 1;
            }
            else if (a.Fecha < b.Fecha)
            {
                return -1;
            }
            return 0;
        }
        #endregion
        #region Sobrecargas

        /// <summary>
        /// c.La sobrecarga del operador == debe verificar si el producto se encuentra en la lista de
        ///productos comparando la descripción.
        ///Si dos productos tienen la misma descripción son el mismo producto.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria is not null && producto is not null)
            {
                //Guid auxCodigo = (Guid)producto;
                //if (comiqueria.productos[auxCodigo] is not null)
                //{
                //    return true;
                //}
                foreach (Producto item in comiqueria.productos)
                {
                    if (((Guid)producto) == ((Guid)item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        /// <summary>
        ///e.La sobrecarga del operador + debe agregar un producto a la lista de producto
        ///siempre que el mismo ya no exista en la lista.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }
        #endregion

    }
}
