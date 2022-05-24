using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T>
        where T : Equipo
    {
        //x i.Generar la clase Torneo con un tipo genérico.
        //x  1. Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
        //x  2. Tendrá un atributo equipos : List<T> y otro nombre : string.
        //x  3. Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
        //x  4. Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando este no se encuentre ya en el torneo.
        //x  5. El método Mostrar retornará los datos del torneo y de los equipos participantes.
        //x  6. El método privado CalcularPartido(T, T): string recibirá dos elementos del tipo
        //  T, que deberán ser del tipo Equipo o sus herencias, y calculará utilizando
        //  Random un resultado del partido. Retornará el resultado con el siguiente
        //  formato: “[EQUIPO1][RESULTADO1] – [RESULTADO2][EQUIPO2]”, siendo
        //  EQUIPOX el nombre del equipo y RESULTADOX la cantidad de goles/puntos.
        //x  7. La propiedad pública JugarPartido tomará dos equipos de la lista al azar y
        //  calculará el resultado del partido a través del método CalcularPartido.
        private List<T> equipos;
        private string nombre;
        #region Constructores
        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion
        #region Sobrecargas
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        /// <summary>
        /// Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando
        /// este no se encuentre ya en el torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo is not null && equipo is not null && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }
        #endregion
        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                T equipoA;
                T equipoB;
                do
                {
                    equipoA = this.equipos[random.Next(0, equipos.Count())];
                    equipoB = this.equipos[random.Next(0, equipos.Count())];
                } while (equipoA == equipoB);
                return CalcularPartido(equipoA, equipoB);
            }
        }
        /// <summary>
        /// 5. El método Mostrar retornará los datos del torneo y de los equipos participantes.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T e1, T e2)
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            return $"{e1.Nombre} {r.Next(0, 10)} - {e2.Nombre} {r.Next(0, 10)}";
        }
    }
}
