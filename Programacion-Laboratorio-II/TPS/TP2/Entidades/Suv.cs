using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Le saqué el sealed a esta clase porque considero que puede ser necesario en el futuro
    //Heredar la clase Suv para reutilizar código en clases derivadas mas especificas
    public class Suv : Vehiculo
    {
        #region Constructor
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion
        #region Propiedad
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Grande;
            }
        }
        #endregion
        #region Metodo Mostrar()
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------\n");
            return sb.ToString();
        }
        #endregion
    }
}
