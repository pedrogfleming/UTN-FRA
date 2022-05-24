using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescribiendoAdvertencias
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        #region Propiedad
        public abstract string MiAtributo {get;}
        #endregion

        public abstract string MiMetodo();       

        #region Sobrecarga de metodos de object
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();    
        }
        public override int GetHashCode()
        {
            return 1142510181; 
        }
        #endregion

    }
}
