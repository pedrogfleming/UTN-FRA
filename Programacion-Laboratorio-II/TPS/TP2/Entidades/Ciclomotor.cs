using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Le saqué el sealed a esta clase porque considero que puede ser necesario en el futuro
    //Heredar la clase Ciclomotor para reutilizar código en clases derivadas mas especificas
    public class Ciclomotor : Vehiculo
    {        
        #region Constructor
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        #endregion
        #region Propiedad
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Chico;
            }
        }
        #endregion
        #region Metodo Mostrar()
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------\n");
            return sb.ToString();
        }
        #endregion
    }
}
