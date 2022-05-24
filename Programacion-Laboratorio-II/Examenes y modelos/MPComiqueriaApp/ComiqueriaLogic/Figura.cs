using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        //x  a.Hereda de la clase Producto.
        //x  b.Los constructores inicializan todos los campos con los parámetros de entrada.
        //x  c.Tiene una sobrecarga del constructor que no recibe descripción.En su lugar inicializará ese
        //  campo con el siguiente texto "Figura *altura* cm", donde *altura* corresponde al valor de la
        //  altura de la figura.Reutilizar código en las sobrecargas, no repetir. 
        //x  d.Sobrescribir el método ToString. Agregar a lo devuelto por el ToString de la clase base los
        //      datos de la Figura (Altura). Seguir el mismo formato y metodología utilizado en la clase base.
        private double altura;
        #region Constructores
        /// <summary>
        /// Tiene una sobrecarga del constructor que no recibe descripción.En su lugar inicializará ese
        ///campo con el siguiente texto "Figura *altura* cm", donde *altura* corresponde al valor de la
        ///altura de la figura.
        ///Reutilizar código en las sobrecargas, no repetir. 
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="altura"></param>
        public Figura(int stock, double precio, double altura)
        : this($"Figura *{altura}* ", stock, precio, altura)
        {
        }

        public Figura(string descripcion, int stock, double precio,double altura )
            :base(descripcion,precio,stock)
        {
            this.altura = altura;
        }
        #endregion

        /// <summary>
        /// Sobrescribir el método ToString. 
        /// Agregar a lo devuelto por el ToString de la clase base los datos de la Figura (Altura).
        /// Seguir el mismo formato y metodología utilizado en la clase base.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("\nAutor: {0}", this.altura);
            return sb.ToString();
        }
    }
}
