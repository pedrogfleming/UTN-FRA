using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescribiendoAdvertencias
{
    public class SobreSobrescrito : Sobreescrito
    {        
        public override string MiAtributo
        {
            get
            {
                return this.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.MiAtributo;
        }
    }
}
