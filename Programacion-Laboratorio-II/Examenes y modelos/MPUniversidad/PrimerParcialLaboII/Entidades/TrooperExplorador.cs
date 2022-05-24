using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperExplorador : Troopper
    {
        //x      7. InfoTrooper informará todos sus datos y agregará sobre su vehículo: " – Vehículo: [Vehiculo]".
        //x      Utilizar StringBuilder para lograrlo.
        //x      8. La propiedad Vehiculo validará que el texto no sea vacío (""). De serlo, asignará a vehiculo "Indefinido".
        //x      9. La propiedad tipo retornará "Soldado de exploración".
        //x     10. Su Blaster será el EC17.
        public string vehiculo;
        #region Constructor
        public TrooperExplorador(string vehiculo):base(Blaster.EC17)
        {
            this.Vehiculo = vehiculo;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// La propiedad tipo retornará "Soldado de exploración".
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldado de exploración";
            }
        }
        /// <summary>
        ///  La propiedad Vehiculo validará que el texto no sea vacío (""). De serlo, asignará a vehiculo  "Indefinido".
        /// </summary>
        public string Vehiculo 
        {
            get
            {
                return this.vehiculo;
            }

            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.vehiculo = value;
                }
                else
                {
                    this.vehiculo = "Indefinido";
                }
            }
        
        }
        #endregion
        #region Metodo
        /// <summary>
        /// InfoTrooper informará todos sus datos y agregará sobre su vehículo: " – Vehículo: [Vehiculo]".
        /// </summary>
        /// <returns></returns>
        public override string InfoTrooper()
        {
            StringBuilder aux = new();
            aux.Append(base.InfoTrooper());
            aux.AppendFormat("\n– Vehículo: {0}", this.Vehiculo);
            return aux.ToString();
        }

        #endregion
    }
}
