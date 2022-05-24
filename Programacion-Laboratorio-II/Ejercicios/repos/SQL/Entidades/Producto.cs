using System;

namespace Entidades
{
    public class Producto
    {
        private int id;
        private string descripcion;
        public Producto(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
