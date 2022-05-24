using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        //x a.Hereda de Equipo.
        //x  b.Poseerá un atributo booleano, para determinar si posee o no  “jugadoresEstrellas”.
        //x  c.Por defecto un EquipoFutbol no poseerá “jugadoresEstrellas”.
        //x  d.GetDificultad retornará un numero Random entre 7 y 10. En caso de
        //x  poseer “jugadoresEstrellas” este valor se deberá de duplicar.
        //x  e.MostrarDatos agregara “Futbol –“al nombre del objeto.
        //x  f.ToString hará público MostrarDatos.

        private bool jugadoresEstrellas;
        #region Constructores
        /// <summary>
        /// c.Por defecto un EquipoFutbol no poseerá “jugadoresEstrellas”.
        /// </summary>
        /// <param name="nombre"></param>
        public EquipoFutbol(string nombre) :this(nombre,false)
        {
        }
        public EquipoFutbol(string nombre,bool jugadoresEstrellas) : base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// d.GetDificultad retornará un numero Random entre 7 y 10. En caso de
        ///poseer “jugadoresEstrellas” este valor se deberá de duplicar.
        /// </summary>
        /// <returns></returns>
        public override int GetDificultad()
        {
            Random rAux = new Random();
            if (this.jugadoresEstrellas == true)
            {
                return (rAux.Next(7, 10)*2);
            }
            return rAux.Next(7, 10);
        }
        /// <summary>
        /// e.MostrarDatos agregara “Futbol –“al nombre del objeto.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Futbol – ");
            sb.Append(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
