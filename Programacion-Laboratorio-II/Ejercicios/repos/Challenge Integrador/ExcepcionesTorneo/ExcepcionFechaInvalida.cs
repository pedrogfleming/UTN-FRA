using System;

namespace ExcepcionesTorneo
{
    public class ExcepcionFechaInvalida : Exception
    {
        public ExcepcionFechaInvalida(string message) : this(message,null)
        {
        }
        public ExcepcionFechaInvalida(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
