using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_EjercicioVehiculos
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
    : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.PesoCarga = pesoCarga;
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
                if (value >= 1 && value <= 6)
                {
                    this.cantidadMarchas = value;
                }
            }
        }
        public int PesoCarga
        {
            get
            {
                return this.pesoCarga;
            }
            set
            {
                if (value > 0 && value <= 75)           //en toneladas
                {
                    this.pesoCarga = value;
                }
            }
        }

        #endregion
        #region MostrarDatos()
        new public string MostrarDatos()
        {
            return base.MostrarDatos() + $"Cantidad de Peso Carga : {this.PesoCarga}" +
                $"\nCantidad de Marchas: {this.CantidadMarchas}";
        }
        #endregion

    }
}
