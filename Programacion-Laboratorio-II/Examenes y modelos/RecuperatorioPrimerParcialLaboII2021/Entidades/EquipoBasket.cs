using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {
        //x  a.Hereda de Equipo.
        //x b.Poseerá un Enum con los siguientes tipos: {NBA,Euroleague,ACB}
        //x  c.El atributo Liga será del tipo del enumerado y privado.
        //x d.Por defecto EquipoBasket su liga será NBA.
        //x  e.GetDificultad retornara un numero Random.Si el equipo es de la liga NBA, su valor será en 8 y 10. EuroLeague entre 5 y 10, ACB entre 1 y 7.
        //x  f.MostrarDatos agregara “Basket –“al nombre del objeto.
        //x  g.ToString hará público MostrarDatos.
        public enum ELiga { NBA, Euroleague, ACB };
        private ELiga liga;
        #region Constructores
        /// <summary>
        /// d.Por defecto EquipoBasket su liga será NBA.
        /// </summary>
        /// <param name="nombre"></param>
        public EquipoBasket(string nombre):this(nombre, ELiga.NBA)
        {
        }
        public EquipoBasket(string nombre,ELiga liga): base(nombre)
        {
            this.liga = liga;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// GetDificultad retornara un numero Random.Si el equipo es de la liga
        ///NBA, su valor será en 8 y 10. EuroLeague entre 5 y 10, ACB entre 1 y 7.
        /// </summary>
        /// <returns></returns>
        public override int GetDificultad()
        {
            Random rAux = new Random();
            if(this.liga == ELiga.NBA)
            {
                return rAux.Next(8, 10);
            }
            else if(this.liga == ELiga.Euroleague)
            {
                return rAux.Next(5, 10);
            }
            else if(this.liga == ELiga.ACB)
            {
                return rAux.Next(1, 7);
            }
            return 0;
        }
        /// <summary>
        /// f.MostrarDatos agregara “Basket –“al nombre del objeto.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basket – ");
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
