using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        //x  a.Todos sus atributos son privados.
        //x  Poseerá una lista de Equipos, un nombre y una cantidad de Competidores.
        //x  b.Su constructor privado asignara por defecto 5 (cinco) a cantidadCompetidores.
        //x  c.Su constructor público:
        //x  i.Instanciara la lista.
        //x  ii.Asignara un nombre.
        //x  iii.Inicializara la cantidad de competidores.
        //x  d.La propiedad Equipos será de solo Lectura.
        //x  e.La conversión Implícita de un string retornara una instancia de una Competencia.
        //x  f.Una Competencia y un Equipo serán iguales si este ya se encuentra de dentro de la competencia.Comparar por nombre(reutilizar código).
        //x  g.Sobrecargar el operador + para agregar un Equipo a la competencia.
        //x  Solo se podrá agregar si este no se encuentra en esta y la competencia aun dispone de capacidad.
        //x  h.MostrarTorneo será de Clase, recibe una competencia y expondrá los datos de la competencia en conjunto con la lista de competidores. Utilizar StringBuilder.

        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        #region Constructores
        /// <summary>
        /// b.Su constructor privado asignara por defecto 5 (cinco) a cantidadCompetidores.
        /// </summary>
        /// <param name="nombre"></param>
        private Competencia(string nombre) : this(nombre,5)
        {
        }
        /// <summary>
        /// c.Su constructor público:
        ///i.Instanciara la lista.
        ///ii.Asignara un nombre.
        ///iii.Inicializara la cantidad de competidores.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidadCompetidores"></param>
        public Competencia(string nombre,int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.Nombre = nombre;
            this.CantidadCompetidores = cantidadCompetidores;
        }
        #endregion
        #region Propiedades
        public int CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                if (value >= 0)
                {
                    this.cantidadCompetidores = value;
                }
            }
        }
        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
            }
        }

        #endregion
        #region Sobrecargas

        /// <summary>
        /// e.La conversión Implícita de un string retornara una instancia de una Competencia.
        /// </summary>
        /// <param name="nombre"></param>
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }
        /// <summary>
        /// Una Competencia y un Equipo serán iguales si este ya se encuentra de dentro de la competencia.Comparar por nombre(reutilizar código).
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator ==(Competencia torneo,Equipo equipo)
        {
            if(torneo is not null && equipo is not null)
            {
                foreach (Equipo item in torneo.Equipos)
                {
                    if(item == equipo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }
        /// <summary>
        /// g.Sobrecargar el operador + para agregar un Equipo a la competencia.
        /// Solo se podrá agregar si este no se encuentra en esta y la competencia aun dispone de capacidad.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if(torneo.CantidadCompetidores > torneo.Equipos.Count() && torneo != equipo)
            {
                torneo.Equipos.Add(equipo);
            }
            return torneo;
        }
        /// <summary>
        /// h.MostrarTorneo será de Clase, recibe una competencia y expondrá los datos de la competencia en conjunto con la lista de competidores.
        /// </summary>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre Competencia: {0}\n", torneo.Nombre);
            sb.AppendFormat("Cantidad Competidores: {0}\n", torneo.CantidadCompetidores);
            foreach (Equipo item in torneo.Equipos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}
