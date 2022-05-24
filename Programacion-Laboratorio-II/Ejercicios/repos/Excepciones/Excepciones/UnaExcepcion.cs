using System;

namespace Excepciones
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
