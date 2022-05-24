using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Modficar lo que fuere necesario para su implementacion
    public interface IAtendedor
    {
        Queue<Cliente> FilaClientes { get; set; }
        string NombrePuestoAtencion { get; }
        string AtenderClientes();
    }
}
