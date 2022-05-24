using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    //Le saqué el sealed a esta clase porque considero que puede ser necesario en el futuro
    //Heredar la clase Sedan para reutilizar código en clases derivadas mas especificas
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas };
        private ETipo tipo;
        #region Constructor
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca,chasis,color, ETipo.CuatroPuertas)
        {            
        }
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo)
                : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        #endregion
        #region Propiedad
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion
        #region Metodo Mostrar()
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());            
            sb.AppendLine(string.Format("TIPO : {0}",this.tipo));
            sb.AppendLine("---------------------\n");
            return sb.ToString();
        }
        #endregion

    }
}
