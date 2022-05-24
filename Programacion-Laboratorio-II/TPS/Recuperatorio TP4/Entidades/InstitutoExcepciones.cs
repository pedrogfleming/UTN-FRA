using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InstitutoExcepciones : Exception
    {
        public InstitutoExcepciones(string message) : base(message)
        {
        }

        public InstitutoExcepciones(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
