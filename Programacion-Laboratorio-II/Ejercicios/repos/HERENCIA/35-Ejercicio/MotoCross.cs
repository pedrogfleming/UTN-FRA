using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Ejercicio
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;
        #region Constructores
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        public MotoCross(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
            this.Cilindrada = caballosDeFuerza;
        }
        #endregion
        #region Propiedades
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                if (value >= 1)
                {
                    this.cilindrada = value;
                }
            }
        }
        #endregion
        #region Mostrar Datos
        new public string MostrarDatos()
        {
            return base.MostrarDatos() + Cilindrada.ToString();
        }
        #endregion
        #region Sobrecarga == & !=
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1 == a2 && a1.Cilindrada == a2.Cilindrada)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
