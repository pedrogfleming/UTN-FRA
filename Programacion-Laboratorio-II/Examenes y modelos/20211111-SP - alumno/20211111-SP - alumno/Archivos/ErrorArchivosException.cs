using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivosException : Exception
    {
        public ErrorArchivosException(string message) : this(message,null)
        {
        }

        public ErrorArchivosException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
