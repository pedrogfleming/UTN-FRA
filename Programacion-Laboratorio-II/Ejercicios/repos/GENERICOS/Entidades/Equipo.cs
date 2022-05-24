using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        //x Agregar un atributo nombre : string y otro fechaCreacion : datetime.
        //x 2. Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
        //x 3. El método Ficha retornará el nombre del equipo y su fecha de creación con el
        //siguiente formato “[EQUIPO] fundado el[FECHA]”.
        private string nombre;
        private DateTime fechaCreacion;

        #region Constructor
        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        #endregion
        public string  Nombre 
        {
            get
            {
                return this.nombre;
            }
        }
        /// <summary>
        /// El método Ficha retornará el nombre del equipo y su fecha de creación con el
        ///siguiente formato “[EQUIPO] fundado el[FECHA]”.
        /// </summary>
        /// <returns></returns>
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} fundado el {1}", this.nombre, this.fechaCreacion.ToShortDateString());
            return sb.ToString();
        }
        #region Sobrecargar == & !=
        public static bool operator ==(Equipo a,Equipo b)
        {
            if(a is not null && b is not null)
            {
                return (a.nombre == b.nombre && a.fechaCreacion == b.fechaCreacion);
            }
            return false;
        }
        /// <summary>
        /// 2. Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }
        #endregion
    }
}
