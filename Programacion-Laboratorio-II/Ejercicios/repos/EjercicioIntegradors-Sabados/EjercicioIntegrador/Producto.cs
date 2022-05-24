using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        #region Constructor
        public Producto(string marca, string codigo, float precio)
        {
            if (!String.IsNullOrWhiteSpace(marca) &&
                !String.IsNullOrWhiteSpace(codigo) &&
                precio > 0)
            {
                this.codigoDeBarra = codigo;
                this.marca = marca;
                this.precio = precio;
            }
        }
        #endregion
        #region Getters
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        #endregion
        #region Mostrar()
        public string MostrarProducto(Producto p)
        {
            return p.GetMarca() + p.GetPrecio().ToString() + (string)p;
        }

        #endregion
        #region Sobrecargas == & != 
        public static bool operator ==(Producto p1, Producto p2)        //p1 llega null
        {
            if(p1.GetMarca() == p2.GetMarca() && (string)p1 == (string) p2)//si la marca y el codigo de barra son igual, es ==
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, string marca)
        {
            if(p.GetMarca() == marca)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p==marca);
        }
        #endregion
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        
    }
}
