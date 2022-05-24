using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_EjercicioVehiculos
{
    public class Moto:VehiculoTerrestre
    {
        private short cilindrada;
        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            :base(cantidadRuedas, cantidadPuertas, color)
        {
            this.Cilindrada = cilindrada;
        }
        #region Propiedades
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                if (value >= 1 && value <= 2458) //cc
                {
                    this.cilindrada = value;
                }
            }
        }
        #endregion
        #region MostrarDatos()
        new public string MostrarDatos()
        {
            return base.MostrarDatos() + $"Cilindrada : {this.Cilindrada}";
        }
        #endregion
    }
}
