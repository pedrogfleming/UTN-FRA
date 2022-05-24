using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Entidades
{
    public interface IGuardar<T, V>
    {
        bool Guardar(T obj);
        V Leer();
    }
}
