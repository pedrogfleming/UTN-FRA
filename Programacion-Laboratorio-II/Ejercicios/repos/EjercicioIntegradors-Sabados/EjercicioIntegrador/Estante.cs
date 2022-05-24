using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public string MostrarEstante(Estante e)
        {
            StringBuilder auxString = new StringBuilder();
            foreach (Producto item in e.productos)
            {
                auxString.Append(item.MostrarProducto(item));
            }
            return auxString.ToString();
        }
        public static bool operator ==(Estante e,Producto p)
        {
            foreach (Producto item in e.productos)
            {
                if (item is not null && item == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)              //si en el estante no esta el producto
            {
                //foreach (Producto item in e.productos)
                //{
                //    if(item is null)
                //    {
                //        e.productos.
                //        e.productos.Append(p);  //el append no esta agregando el producto
                //        return true;
                //    }
                //}
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
                
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                Estante auxEstante = new Estante((e.productos.Length - 1), e.ubicacionEstante);
                foreach (Producto item in e.productos)
                {
                    if(item != p)
                    {
                        auxEstante.productos.Append(item);
                    }
                }
                return auxEstante;
            }
            return e;
        }

    }
}