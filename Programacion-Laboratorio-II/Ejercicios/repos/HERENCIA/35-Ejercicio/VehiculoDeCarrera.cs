using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Ejercicio
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #region Propiedades
        public short CantidadCombustible 
        { 
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                if(value >= 15 && value <= 100)
                {
                    this.cantidadCombustible = value;
                }
            }        
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    this.escuderia = value;
                }
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                if(value >= 1)
                {
                    this.numero = value;
                }
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion
        #region Constructor
        public VehiculoDeCarrera(short numero,string escuderia)
        {
            if (!String.IsNullOrEmpty(escuderia) && numero >= 0)
            {
                this.EnCompetencia = false;
                this.VueltasRestantes = 0;
                this.Numero = numero;
                this.Escuderia = escuderia;
            }
        }
        #endregion
        #region Mostrar Datos
        public string MostrarDatos()
        {
            return $"El auto numero: {this.Numero}" +
                $"\nEscuderia: {this.Escuderia}" +
                $"\nEn competencia: {this.EnCompetencia}" +
                $"\nCantidad de combustible: {this.CantidadCombustible}" +
                $"\nVueltas restantes: {this.VueltasRestantes}";
        }
        #endregion
        #region Sobrecarga == & !=
        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }

}
