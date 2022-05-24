using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IMetodosArchivos<T>
    {
        string GenerarRutaCompleta { get;}
        bool ExisteArchivo(string nombreArchivo);
        void Guardar(string nombreArchivo, T Objeto);
        void Leer(string nombreArchivo, out T objeto);
    }
}
