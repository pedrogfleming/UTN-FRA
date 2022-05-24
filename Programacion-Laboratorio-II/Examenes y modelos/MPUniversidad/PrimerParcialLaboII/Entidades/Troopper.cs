using System;
using System.Text;
namespace Entidades
{
    public abstract class Troopper
    {
        //x      2. La clase abstracta Trooper tendrá 2 atributos protegidos.
        //x      3. Por defecto, todos los Troopers NO serán clones. Reutilizar los constructores de forma que se logre esto.
        //x      4. La propiedad Armamento será de sólo lectura, y Tipo será abstracta.
        //.x      5   InfoTrooper retornará la información del soldado con el siguiente formato: "[Tipo] armado con 
        // x       [Armamento], [SI/NO] es clone." Utilizar el método Format de String para lograrlo.
        //x      6. Equals retornará TRUE si ambos objetos son del tipo TYPE

        protected Blaster armamento;
        protected bool esClon;
        #region Constructores
        //public Troopper(Blaster armamento)
        //{
        //    this.armamento = armamento;
        //}
        //public Troopper(Blaster armamento, bool esClon)
        //    : this(armamento)
        //{
        //    this.EsClon = esClon;
        //}
        #region version alternativa
        public Troopper(Blaster armamento):this(armamento,false)
        {
        }
        public Troopper(Blaster armamento, bool esClon)
        {
            this.armamento = armamento;
            this.EsClon = esClon;
        }
        #endregion
        #endregion
        #region Propiedades
        public Blaster Armamento
        {
            get
            {
                return this.armamento;
            }
        }
        public abstract string Tipo { get; }
        public bool EsClon
        {
            get
            {
                return this.esClon;
            }
            set
            {
                this.esClon = value;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// InfoTrooper retornará la información del soldado con el siguiente formato:
        /// "[Tipo] armado con [Armamento], [SI/NO] es clone." Utilizar el método Format de String para lograrlo.
        /// </summary>
        /// <returns></returns>
        public virtual string InfoTrooper()
        {
            string esClon = "NO";
            if (this.EsClon)
            {
                esClon = "SI";
            }
            return String.Format("{0} armado con una {1}, {2} es clone.", this.Tipo, this.Armamento, esClon);
        }
        #endregion
        #region Sobrecarga Equals
        /// <summary>
        /// Equals retornará TRUE si ambos objetos son del tipo TYPE
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
            #region Alternativa
                        /*
            if ((obj == null))
            {
                return false;
            }
            else if (this.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            return false;
            */
            #endregion

        }
        #endregion
    }
}
