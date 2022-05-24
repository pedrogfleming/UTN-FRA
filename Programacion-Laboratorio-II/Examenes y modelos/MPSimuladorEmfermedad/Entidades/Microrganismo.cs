using System;
using System.Text;

namespace Entidades
{
    //x El contador será definido en 1 en sus constructores.
    //x  sta variable contendrá la cantidad de gente contagiada por esta simulación,
    //x  siendo alterada cada vez que se llame a la propiedad IndiceDeContagios.
    //x Informe retornará un texto con el siguiente formato:
    //x  "El TIPO lleva el nombre de NOMBRE y tiene una contagiosidad CONTAGIOSIDAD.
    //x  Su impacto de contagios se calcula en INDICE DE CONTAGIOS"
    public abstract class Microrganismo
    {
        public enum EContagiosidad { Baja,Moderada,Alta};
        public enum ETipo {Virus,Bacteria };
        internal long contador;
        private EContagiosidad contagiosidad;
        private string nombre;
        private ETipo tipo;

        #region Constructores
        public Microrganismo(string nombre)
        {
            this.nombre = nombre;
            contador = 1;
        }
        public Microrganismo(EContagiosidad contagiosidad, string nombre, ETipo tipo):this(nombre)
        {
            this.contagiosidad = contagiosidad;
            this.tipo = tipo;
            
        }
        #endregion
        #region Propiedades
        public  abstract long IndiceDeContagios
        {
            get;
        }
        #endregion

        public virtual string Informe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"El {this.tipo} lleva el nombre de {this.nombre} y tiene una contagiosidad {this.contagiosidad}.\nSu impacto de contagios se calcula en {this.IndiceDeContagios}");
            return sb.ToString();
        }
    }
}
