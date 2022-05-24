using System;
using System.Text;
namespace Entidades
{
    public abstract class Equipo
    {
        //x a.Sera abstracta.
        //x b.Todos sus atributos protegidos asi como su constructor son protegidos.
        //x  c.Las propiedades Nombre y Tipo serán de solo lectura.Tipo retornara la propiedad Name del Type de la instancia.
        //x  d.Sobrescribir el Equals para comparar los Types de Equipo.
        //x  e.La sobrecarga del operador == retornara True si los nombres y el Type del equipo son iguales (Reutilizar código).
        //x  f.MostrarDatos es protegido y solo retornara el nombre del Equipo.Utilizar StringBuilder.
        //x  g.JugarPartido:
        //x  i.Será de clase, recibe 2 equipos, y será el método encargado de
        //x simular el juego entre estos.
        //x ii.Este método retornara True si se pudo Jugar el partido, el cual,
        //x solo se podrá llevar a cabo si ambos Equipos son del mismo Type
        //x (Reutilizar Código).
        //x  iii.Se comparará la dificultad de cada Equipo a través del método
        //x GetDificultad para determinar el ganador.
        //x iv.Al jugar partido se deberá a ambos Equipos incrementar el valor
        // de Partidos Jugados. 
        //x  v.El que tenga la mayor dificultad (el ganador) sumara 3 Puntos,
        //x  en caso de ser igual (empate), ambos sumaran 1 Punto.
        //x  h.GetDificultad deberá implementarse en sus clases derivadas.

        protected string nombre;
        protected int partidoEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        #region Constructor
        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Tipo retornara la propiedad Name del Type de la instancia.
        /// </summary>
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

        }
        public int PE
        {
            get
            {
                return this.partidoEmpatados;
            }
            set
            {
                if (value >= 0)
                {
                    this.partidoEmpatados = value;
                }
            }
        }
        public int PG
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                if (value >= 0)
                {
                    this.partidosGanados = value;
                }
            }
        }
        public int PJ
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                if (value >= 0)
                {
                    this.partidosJugados = value;
                }
            }
        }
        public int PP
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                if (value >= 0)
                {
                    this.partidosPerdidos = value;
                }
            }
        }
        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                if (value >= 0)
                {
                    this.puntuacion = value;
                }
            }
        }
        #endregion
        #region Sobrecarga equals
        /// <summary>
        /// d.Sobrescribir el Equals para comparar los Types de Equipo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.Tipo == obj.GetType().Name;
        }
        #endregion
        #region Sobrecarga del == & !=
        /// <summary>
        /// e.La sobrecarga del operador == retornara True si los nombres y el Type
        ///del equipo son iguales 
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA is not null && equipoB is not null)
            {
                return (equipoA.Tipo == equipoB.Tipo && equipoA.Nombre == equipoB.Nombre);
            }
            return false;
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
        #endregion
        #region Metodos
        /// <summary>
        /// f.MostrarDatos es protegido y solo retornara el nombre del Equipo.Utilizar StringBuilder.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Nombre);
            return sb.ToString();
        }
        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if(equipoA is not null && equipoB is not null)
            {
                if (equipoA.Equals(equipoB))
                {
                    equipoA.PJ += 1;
                    equipoB.PJ += 1;
                    int auxA = equipoA.GetDificultad();
                    int auxB = equipoB.GetDificultad();
                    if (auxA > auxB)
                    {
                        equipoA.Puntuacion += 3;
                    }
                    else if(auxA < auxB)
                    {
                        equipoB.Puntuacion += 3;
                    }
                    else
                    {
                        equipoA.Puntuacion += 1;
                        equipoB.Puntuacion += 1;
                    }
                    return true;
                }
            }
            return false;            
        }        
        public abstract int GetDificultad();
        #endregion
    }
}
