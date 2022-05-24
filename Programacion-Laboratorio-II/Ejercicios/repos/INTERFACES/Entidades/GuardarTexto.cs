using System;

namespace Entidades
{
    public class GuardarTexto<T,V> : IGuardar<T, V>
    {
        /// <summary>
        /// El método Guardar simplemente retornará True.
        /// </summary>
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            return (V)Convert.ChangeType("Texto Leido",typeof(V));
        }
    }
}
