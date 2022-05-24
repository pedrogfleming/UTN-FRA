using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_EjercicioVehiculos
{
    public class VehiculoTerrestre
    {        
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
        #region Propiedades
        public short CantidadRuedas 
        {
            get
            {
                return this.cantidadRuedas;
            }
            set
            {
                if(value >= 2 && value <= 8)
                {
                    this.cantidadRuedas = value;
                }
            }
        }
        public short CantidadPuertas
        {
            get
            {
                return this.cantidadPuertas;
            }
            set
            {
                if(value >= 0 && value <= 4)
                {
                    this.cantidadPuertas = value;
                }
            }
        }
        public Colores Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        #endregion
        public string MostrarDatos()
        {
            return $"El vehiculo es de colors : {this.Color}" +
                $"\nCantidad de ruedas: {this.CantidadRuedas}" +
                $"\nCantidad de puertas: {this.CantidadPuertas}";
        }
    }
}
