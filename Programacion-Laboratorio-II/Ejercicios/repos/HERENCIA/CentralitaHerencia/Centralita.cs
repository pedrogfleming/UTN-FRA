using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        //j.El método Mostrar pasará a ser privado y será llamado por la sobreescritura del método ToString.        x
        //k.AgregarLlamada es privado. Recibe una Llamada y la agrega a la lista de llamadas.                       x
        //l.El operador == retornará true si la Centralita contiene la Llamada en su lista genérica.                x
        //Utilizar sobrecarga == de Llamada.                                                                        x
        //m.El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita  x       
        //(utilizar la sobrecarga del operador == de Centralita).                                                   x
        public enum TipoLlamada { Local, Provincial };
        private List<LLamada> listaDeLLamadas;
        protected string razonSocial;
        #region Constructores
        public Centralita()
        {
            this.listaDeLLamadas = new List<LLamada>();
        }
        public Centralita(string razonSocial) : this()
        {
            if (!string.IsNullOrWhiteSpace(razonSocial))
            {
                this.razonSocial = razonSocial;
            }
        }
        #endregion    
        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial) + this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public List<LLamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }
        #endregion
        #region Metodos
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float auxTotalCosto = 0;
            foreach (LLamada item in this.Llamadas)
            {
                if (tipo == TipoLlamada.Local)
                {
                    if (item.GetType() == typeof(Local))
                    {
                        auxTotalCosto += ((Local)item).CostoLlamada;
                    }
                }
                else if (tipo == TipoLlamada.Provincial)
                {
                    if (item.GetType() == typeof(Provincial))
                    {
                        auxTotalCosto += ((Provincial)item).CostoLlamada;
                    }
                }
            }
            return auxTotalCosto;
        }
        /// <summary>
        /// Recibe una Llamada y la agrega a la lista de llamadas. 
        /// </summary>
        /// <param name="nuevaLlamada"></param>
        private void AgregarLlamada(LLamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }
        private string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine(string.Format(("Razon social : {0}"), this.razonSocial));
            
            aux.AppendLine(string.Format("Ganancias por Total {0}", this.GananciasPorTotal));
            aux.AppendLine(string.Format("Ganancias por Local{0}", this.GananciasPorLocal));
            aux.AppendLine(string.Format("Ganacias por provincial{0}", this.GananciasPorProvincial));
            aux.AppendLine("**********************************************************************");
            foreach (LLamada item in this.Llamadas)
            {
                aux.AppendFormat("\nLLamada {0} {1}",item.GetType(), item.ToString());                
            }
            return aux.ToString();
        }
        public void OrdenarLLamadas()
        {
            this.Llamadas.Sort(LLamada.OrdenarPorDuracion);
        }
        #endregion
        #region Sobrecarga == & !=
        /// <summary>
        ///El operador == retornará true si la Centralita contiene la Llamada en su lista genérica.
        ///Utiliza sobrecarga == de Llamada.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="llamada"></param>
        /// <returns></returns>
        public static bool operator ==(Centralita c, LLamada llamada)
        {
            foreach (LLamada item in c.Llamadas)
            {
                if(item == llamada)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        ///El operador != retornará false si la Centralita contiene la Llamada en su lista genérica.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="llamada"></param>
        /// <returns></returns>
        public static bool operator !=(Centralita c, LLamada llamada)
        {
            return !(c == llamada);
        }
        #endregion
        #region Sobrecarga + (Agregar Llamada)
        /// <summary>
        /// El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita
        /// </summary>
        /// <param name="c"></param>
        /// <param name="nuevaLlamada"></param>
        /// <returns>Retorna la centralita modificada o no</returns>
        public static Centralita operator +(Centralita c, LLamada nuevaLlamada)
        {
            // b.En el operador + de Centralita, lanzar la excepción CentralitaExcepction
            // en el caso de que la llamada se encuentre registrada en el sistema.
            // c.Capturar dicha excepción tanto en la versión para Consola como en la de Formularios y
            //mostrar el mensaje de forma “amigable” al usuario.
            if(c == nuevaLlamada)
            {
                throw new CentralitaExcepcion("La llamada se encuentre registrada en el sistema",
                    "Centralita","sobrecarga +");
            }
            if (c is not null && nuevaLlamada is not null && c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
                    
            }                
            return c;            
        }
        #endregion
        #region Override ToString()
        /// <summary>
        /// Invoca al metodo mostrar de Centralita
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
