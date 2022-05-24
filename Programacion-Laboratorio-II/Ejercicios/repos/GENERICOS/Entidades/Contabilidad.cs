using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*x  Crear un constructor que no reciba parámetros en Contabilidad para inicializar las listas.
     x   b. El constructor sin parámetros de Recibo asignará 0 como número de documento.
    x    c. Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
    x    d. El tipo U deberá tener una restricción que indique que deberá tener un constructor por
        defecto (sin argumentos).
        e. El operador + entre Contabilidad y T agrega un elemento a la lista egresos.
        f. El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
        g. Generar el código necesario para probar dichas clases.
     */

    public class Contabilidad<T,U>
        where T :  Documento
        where U : Documento,new()

    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        /// <summary>
        /// El operador + entre Contabilidad y T agrega un elemento a la lista egresos.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="egreso"></param>
        /// <returns></returns>
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c,T egreso)
        {
            if(c is not null && egreso is not null)
            {
                c.egresos.Add(egreso);
            }
            return c;
        }
        /// <summary>
        /// f. El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="ingreso"></param>
        /// <returns></returns>
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (c is not null && ingreso is not null)
            {
                c.ingresos.Add(ingreso);
            }
            return c;
        }        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in this.egresos)
            {
                sb.AppendLine("Egreso " + item.Numero);
            }
            foreach (U item in this.ingresos)
            {
                sb.AppendLine("Ingreso " + item.Numero);
            }
            return sb.ToString();
        }

    }
}
