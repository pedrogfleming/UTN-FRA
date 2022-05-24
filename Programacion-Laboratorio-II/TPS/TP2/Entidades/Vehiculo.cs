using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca{ Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson};
        public enum ETamanio {Chico, Mediano, Grande};

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #region Constructor
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion
        #region Metodo Mostrar(
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion
        #region Sobrecarga explicita String 
        /// <summary>
        /// Sobrecarga el string en Vehiculo para que muestre todos sus atributos
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("CHASIS: {0}", p.chasis));
            sb.AppendLine(string.Format("MARCA : {0}", p.marca));
            sb.AppendLine(string.Format("COLOR : {0}", p.color));            
            sb.AppendLine("---------------------\n");
            sb.AppendLine(string.Format("TAMAÑO : {0}", p.Tamanio));
            return sb.ToString();
        }
        #endregion
        #region Sobrecargas == & !=
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
