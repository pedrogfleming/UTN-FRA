using System;
using System.Text;
namespace Entidades
{

    public abstract class LLamada
    {
        //a.La clase Llamada ahora será abstracta.  X
        //Tendrá definida la propiedad de sólo lectura CostoLlamada que también será abstracta. X
        //b.Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá los atributos propios de la clase Llamada X
        //c.El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
        //(utilizar método Equals, sobrescrito en las clases derivadas)
        //y los números de destino y origen son iguales en ambas llamadas.
        public enum TipoLlamada { Local, Provincial, Todas };
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #region Propiedades
        public abstract float CostoLlamada { get;}
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion
        #region Constructor
        public LLamada(float duracion, string nroDestino, string nroOrigen)
        {
            if (duracion > 0 && !string.IsNullOrEmpty(nroDestino) && !string.IsNullOrEmpty(nroOrigen))
            {
                this.duracion = duracion;
                this.nroDestino = nroDestino;
                this.nroOrigen = nroOrigen;
            }
        }
        #endregion
        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append("---------------------------------------------------------------\n");
            aux.AppendFormat("Duracion: {0} \n", this.Duracion);
            aux.AppendFormat("Nro Destino :{0} \n", this.NroDestino);
            aux.AppendFormat("Nro Origen :{0} \n", this.NroOrigen);
            return aux.ToString();
        }
        /// <summary>
        /// Compara por duracion de llamada dos llamdas
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns>Retorna 1 si A>B, 2 si A<B o 0 si A=B</returns>
        public static int OrdenarPorDuracion(LLamada llamada1, LLamada llamada2)
        {
            //retornar 
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            return 0;
        }
        #endregion
        #region Sobrecargas == & !=
        /// <summary>
        /// El operador == comparará dos llamadas
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>retornará true si las llamadas son del mismo tipo</returns>
        public static bool operator ==(LLamada l1, LLamada l2)
        {
            return (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen);
        }
        /// <summary>
        /// El operador != comparará dos llamadas
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>retornará false si las llamadas son del mismo tipo</returns>
        public static bool operator !=(LLamada l1, LLamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }

}
