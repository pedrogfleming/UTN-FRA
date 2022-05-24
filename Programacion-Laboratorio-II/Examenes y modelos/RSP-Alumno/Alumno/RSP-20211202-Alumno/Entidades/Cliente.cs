using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int cantProductos;
        private bool prioridad;
        private string nombre;

        public Cliente(string nommbre,int cantProductos, bool prioridad)
        {
            this.nombre = nommbre;
            this.cantProductos = cantProductos;
            this.prioridad = prioridad;
        }

        public int CantProductos { get => cantProductos; set => cantProductos = value; }
        public bool Prioridad { get => prioridad; set => prioridad = value; }

        public override string ToString()
        {
            return $"{this.nombre}";
        }

    }
}
