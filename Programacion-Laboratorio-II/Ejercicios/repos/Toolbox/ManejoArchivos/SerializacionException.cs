using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoArchivos
{
    public class SerializacionException :  Exception
    {
        private static string mensajeError;

        static SerializacionException()
        {
            mensajeError = "Error en la serializacion";
        }

        public SerializacionException() : this(SerializacionException.mensajeError)
        {
        }
        public SerializacionException(string mensaje) : base(mensaje)
        {
        }

        public SerializacionException(Exception innerException) : base(SerializacionException.mensajeError, innerException)
        {
        }
    }
}
