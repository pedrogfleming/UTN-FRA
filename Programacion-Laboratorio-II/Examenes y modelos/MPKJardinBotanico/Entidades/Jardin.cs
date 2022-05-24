using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        //Clase Jardín:
        //a.El Tipo de suelo será estático.     X
        //b.Suelo se inicializará en el constructor estático con el valor Terrozo.      X
        //c.La lista se inicializará en el constructor privado.                         x
        //d.El operador + agregará siempre y cuando espacioTotal sea suficiente para agregar una nueva planta (espacio ocupado + tamaño de la planta). X
        //e.EspacioOcupado retornará el espacio total ocupado por todas las plantas del Jardín.  X
        //f.EspacioOcupado(Planta) retornará el total ocupado + el tamaño de la plata recibida como parámetro.  X
        //g.Sobreescribir el método ToString para que retorne los datos del Jardín:   X
        //Composición del Jardín: TERROZO/ARENOZO   X
        //Espacio ocupado XXX de XXX   X
        public enum Tipo { Terrozo,Arenozo};
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;
        #region Constructores
        static Jardin()
        {
            Jardin.TipoSuelo = Tipo.Terrozo;
        }
        private Jardin()
        {
            this.plantas = new List<Planta>();
        }
        public Jardin(int espacioTotal) : this()
        {            
            this.espacioTotal = espacioTotal;
        }
        #endregion
        #region Propiedades
        public static Tipo TipoSuelo 
        {
            set
            {
                if(value == Tipo.Terrozo)
                {
                    Jardin.suelo = Tipo.Terrozo;
                }
                else if(value == Tipo.Arenozo)
                {
                    Jardin.suelo = Tipo.Arenozo;
                }
            } 
        }
        #endregion
        #region Metodos
        /// <summary>
        /// EspacioOcupado retornará el espacio total ocupado por todas las plantas del Jardín.
        /// </summary>
        /// <returns></returns>
        private int EspacioOcupado()
        {
            return this.plantas.Count();
        }
        /// <summary>
        /// EspacioOcupado(Planta) retornará el total ocupado + el tamaño de la plata recibida como parámetro.
        /// </summary>
        /// <param name="planta"></param>
        /// <returns></returns>
        private int EspacioOcupado(Planta planta)
        {
            return this.plantas.Count() + planta.Tamanio;
        }
        #endregion
        #region Sobrecarga + Agregar Planta a Jardin
        /// <summary>
        /// El operador + agregará siempre y cuando espacioTotal sea suficiente para agregar una nueva planta (espacio ocupado + tamaño de la planta).
        /// </summary>
        /// <param name="jardin"></param>
        /// <param name="planta"></param>
        /// <returns>Retorna True si pudo agregarla, si no False</returns>
        public static bool operator +(Jardin jardin,Planta planta)
        {
            if(jardin.plantas.Count < jardin.espacioTotal)
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }
        #endregion
        #region Sobrecargar toString()
        public override string ToString()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine(String.Format("En el jardin hay un espacio total de : {0} ", this.espacioTotal));
            aux.AppendLine(String.Format("En el jardin hay la siguiente cantidad de plantas : {0} ", this.plantas.Count()));
             aux.AppendLine(String.Format("El tipo de suelo es : {0} ", Jardin.suelo));
            aux.AppendLine("A continuacion, se listan las plantas del jardin:  ");
            foreach (Planta item in this.plantas)
            {
                aux.AppendLine(item.ResumenDeDatos());
            }
            return aux.ToString();
        }
        #endregion
    }
}
