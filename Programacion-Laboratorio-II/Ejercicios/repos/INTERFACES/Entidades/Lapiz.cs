using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        #region Propiedades
        /// <summary>
        /// El color será gris (grey), sin posibilidad de modificarlo. 
        /// El set lanzará NotImplementedException.
        /// </summary>
        ConsoleColor IAcciones.Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }            
            set => throw new NotImplementedException();         
        }
        /// <summary>
        /// UnidadesDeEscritura retornará tamanioMina.
        /// </summary>
        float IAcciones.UnidadesDeEscritura 
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
               this.tamanioMina = value;        
            }
        }
        #endregion
        #region Interfaz Implementada
        /// <summary>
        /// Explicito seria la variacion de mi interfaz
        /// Escribir reducirá la mina en 0.1 por cada carácter escrito.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (!string.IsNullOrWhiteSpace(texto) && ((IAcciones)this).UnidadesDeEscritura >= (float)(texto.Length * 0.1))
            {
                ((IAcciones)this).UnidadesDeEscritura -= (float)(texto.Length * 0.1);
                return new EscrituraWrapper(((IAcciones)this).Color, texto);
            }
            return new EscrituraWrapper(((IAcciones)this).Color, "");
        }
        /// <summary>
        /// Recargar lanzará NotImplementedException.
        /// </summary>
        /// <param name="unidades"></param>
        /// <returns></returns>
        bool IAcciones.Recargar(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
            return false;
        }
        /// <summary>
        /// ToString retornará un texto informando que es , color de escritura y tamanio de mina.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tipo de objeto: {0}", this.GetType().Name);
            sb.AppendFormat("Color de escritura: {0}", ((IAcciones)this).Color);
            sb.AppendFormat("Nivel de tinta: {0}", ((IAcciones)this).UnidadesDeEscritura);
            return sb.ToString();
        }
        //public void Test()
        //{
        //    Lapiz aux = new Lapiz();
        //    aux.Escribir("aaa");
        //    ((IAcciones)aux).Escribir("explicito");
        //}
        #endregion
    }
}
