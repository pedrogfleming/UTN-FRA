using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_AutomovilesF1
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero,string escuderia)
        {
            if (!String.IsNullOrEmpty(escuderia) && numero >= 0)
            {
                this.cantidadCombustible = 0;
                this.enCompetencia = false;
                this.vueltasRestantes = 0;
                this.numero = numero;
                this.escuderia = escuderia;
            }
        }
        public string MostrarDatos()
        {
            
            return $"El auto numero: {this.numero}" +
                $"\nEscuderia: {this.escuderia}" +
                $"\nEn competencia: {this.enCompetencia}" +
                $"\nCantidad de combustible: {this.cantidadCombustible}" +
                $"\nVueltas restantes: {this.vueltasRestantes}";
            
        }
        #region Getters
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        #endregion
        #region Setters
        public void SetCantidadCombustible(short c)
        {
            this.cantidadCombustible = c;
        }
        public void SetEnCompetencia(bool c)
        {
            this.enCompetencia = c;
        }
        public void SetVueltasRestantes(short v)
        {
            this.vueltasRestantes = v;
        }
        #endregion
        #region Sobrecarga == & !=
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.numero == a2.numero && a1.escuderia == a2.escuderia)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
