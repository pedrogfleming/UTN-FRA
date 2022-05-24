using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Ejercicio
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;
        #region Constructores
        public AutoF1(short numero,string escuderia):base(numero, escuderia)
        {
        }
        public AutoF1(short numero, string escuderia,short caballosDeFuerza):base(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        #endregion
        #region Propiedades
        public short CaballosDeFuerza 
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                if(value >= 1)
                {
                    this.caballosDeFuerza = value;
                }
            }
        }
        #endregion
        #region Mostrar Datos
        new public string MostrarDatos()
        {            
            return base.MostrarDatos() +this.CaballosDeFuerza.ToString();
        }
        #endregion
        #region Sobrecarga == & !=
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(a1 == a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza)            
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
