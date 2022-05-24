using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        //x a.Hereda de la clase Producto.
        //x  b.Tiene un enumerado TipoComic con dos posibles valores: Occidental, Oriental.
        //x  c.El constructor inicializa todos los campos con los parámetros de entrada.
        //x  d.Sobrescribir el método ToString.Agregar a lo devuelto por el ToString de la clase base los datos del Comic (Autor y TipoComic).
        //x  Seguir el mismo formato y metodología utilizado en la clase base.
        public enum TipoComic {Occidental,Oriental };
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio,string autor, TipoComic tipoComic) : base(descripcion,precio,stock)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        /// <summary>
        /// d.Sobrescribir el método ToString.
        /// Agregar a lo devuelto por el ToString de la clase base los datos del Comic (Autor y TipoComic).
        ///Seguir el mismo formato y metodología utilizado en la clase base.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("\nAutor: {0}", this.autor);
            sb.AppendFormat("\nTipo de Comic: {0}", this.tipoComic);
            return sb.ToString();
        }

    }
}
