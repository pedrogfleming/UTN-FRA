using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : LLamada
    {
        //d.Sobrescribir el método Mostrar.Será protegido.                                  x
        //Reutilizará el código escrito en la clase base                                    x
        //y además agregará la propiedad CostoLlamada, utilizando un StringBuilder.         x
        //e.Equals retornará true sólo si el objeto que recibe es de tipo Local.            x
        //f.ToString reutilizará el código del método Mostrar.                              x
        protected float costo;
        #region Constructores

        public Local(LLamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo)
    : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion
        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion
        #region Metodos
        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }
        protected override string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(base.Mostrar());
            aux.AppendFormat("Costo LLamada: {0}\n",this.CostoLlamada.ToString());
            return aux.ToString();
        }
        #endregion
        #region Override Equals()
        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Local));
        }
        #endregion
        #region Override ToString()
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
