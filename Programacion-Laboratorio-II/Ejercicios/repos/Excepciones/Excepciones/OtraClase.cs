using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class OtraClase
    {
        /// <summary>
        /// Generar la clase OtraClase con un método de instancia, donde se instancie un objeto MiClase 
        /// y se capture la excepción anterior.
        /// Este método generará una excepción propia llamada MiException y la lanzará.
        /// </summary>
        public OtraClase()
        {
            try
            {
                MiClase auxMiClase = new MiClase(true);
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("Error recibido en Otra clase", e);
            }

        }
    }
}
