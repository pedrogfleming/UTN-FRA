using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        #region Constructor
        public Boligrafo(float unidadesDeEscritura,ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidadesDeEscritura;
        }
        #endregion
        #region Propiedades
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                if(value < 0)
                {
                    this.tinta = 0;
                }
                else
                {
                    this.tinta = value;
                }                
            }
        }

        #endregion
        #region Implementacion IAcciones
        //Implementado de forma implicita
        /// <summary>
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Retorna un objeto de tipo EscrituraWrapper</returns>
        public EscrituraWrapper Escribir(string texto)
        {
            if (!string.IsNullOrWhiteSpace(texto) && this.UnidadesDeEscritura >= (float)(texto.Length * 0.3))
            {
                this.UnidadesDeEscritura -= (float)(texto.Length * 0.3);
                return new EscrituraWrapper(this.Color, texto);
            }
            return new EscrituraWrapper(this.Color, "");
        }
        //Implementado de forma implicita
        /// <summary>
        /// Recargar incrementará tinta en tantas unidades como se agreguen.
        /// </summary>
        /// <param name="unidades"></param>
        /// <returns></returns>
        public bool Recargar(int unidades)
        {           
            this.UnidadesDeEscritura += unidades;
            return true;
        }
        #endregion
        /// <summary>
        /// ToString retornará un texto informando que es , color de escritura y nivel de tinta.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tipo de objeto: {0}",this.GetType().Name);
            sb.AppendFormat("Color de escritura: {0}", this.Color);
            sb.AppendFormat("Nivel de tinta: {0}", this.UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
