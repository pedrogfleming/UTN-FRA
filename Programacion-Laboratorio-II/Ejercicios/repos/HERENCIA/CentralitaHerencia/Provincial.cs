using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Provincial : LLamada
    {
        //g.El método Mostrar será protegido.                                           x
        //Reutilizará el código escrito en la clase base y                              x
        //agregará FranjaHoraria y CostoLlamada, utilizando un StringBuilder.           x
        //h.Equals retornará true sólo si el objeto que recibe es de tipo Provincial.   x
        //i.ToString reutilizará el código del método Mostrar.                          x
        //Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
        public enum Franja { Franja_1, Franja_2, Franja_3 };
        protected Franja franjaHoraria;
        #region Constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, LLamada llamada) 
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
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
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.Duracion * (float)0.99;
                case Franja.Franja_2:
                    return this.Duracion * (float)1.25;
                case Franja.Franja_3:
                    return this.Duracion * (float)0.66;
            }
            return 0;
        }
        protected override string Mostrar()
        {
            StringBuilder aux = new StringBuilder();            
            aux.Append(base.Mostrar());
            aux.AppendFormat("Franja Horaria: {0}\n",this.franjaHoraria.ToString());
            aux.AppendFormat("Costo LLamada: {0}\n",this.CostoLlamada.ToString());
            return aux.ToString();
        }
        #endregion
        #region Override Equals()
        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Provincial));
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
