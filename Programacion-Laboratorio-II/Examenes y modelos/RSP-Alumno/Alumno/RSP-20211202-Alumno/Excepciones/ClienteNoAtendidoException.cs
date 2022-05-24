using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    //8.ClienteNoAtendidoException: su mensaje por defecto será Cliente no prioritario.
    public class ClienteNoAtendidoException : Exception
    {
        public ClienteNoAtendidoException():base("Cliente no prioritario")
        {
        }
    }
}
