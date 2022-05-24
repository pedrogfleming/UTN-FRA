using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_EjercicioVehiculos
{
    public class Automovil: VehiculoTerrestre
    {
        
        private short cantidadMarchas;
        private short cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, short cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadPasajeros = cantidadPasajeros;
        }
        #region Propiedades
        public short CantidadMarchas
        {
            get
            {
                return this.cantidadMarchas;
            }
            set
            {
                if(value >= 1 && value <= 6)
                {
                    this.cantidadMarchas = value;
                }
            }        
        }
        public short CantidadPasajeros
        {
            get
            {
                return this.cantidadPasajeros;
            }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    this.cantidadPasajeros = value;
                }
            }
        }

        #endregion
        #region MostrarDatos()
        new public string MostrarDatos()
        {
            return base.MostrarDatos()+$"Cantidad de Pasajeros : {this.CantidadPasajeros}" +
                $"\nCantidad de Marchas: {this.CantidadMarchas}";
        }
        #endregion

    }
}
