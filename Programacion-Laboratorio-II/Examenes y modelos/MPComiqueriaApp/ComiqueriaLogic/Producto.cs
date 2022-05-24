using System;
using System.Text;
namespace ComiqueriaLogic
{
    public abstract class Producto
    {

        //x a.Clase abstracta.
        //x b.Constructor protegido.
        //Inicializará el campo “codigo” con el método estático NewGuid de la clase Guid.
        //x Iniciar el resto de los campos con los parámetros de entrada.
        //El identificador único global, en inglés: globally unique identifier (GUID) es un número
        //pseudoaleatorio empleado en aplicaciones de software. El GUID es una implementación de
        //Microsoft de un estándar llamado universally unique identifier (UUID), especificado por la
        //Open Software Foundation (OSF).
        //x  c.La propiedad Stock de lectura y escritura.Validará que el stock ingresado sea mayor o igual a
        //x  cero, sino no lo actualizará. 
        //x  d.Las propiedades Precio y Descripcion son de sólo lectura.
        //x e.Tiene un método de conversión explícito transforma un producto en su código. 
        //x  f.Sobrescribir el método ToString para devolver un string con los datos de un producto: 
        //x  descripción, código, precio y stock.Se deberá utilizar StringBuilder y/o métodos de la clase
        //x  String, no utilizar operador + y derivados (no concatenar). El texto devuelto debe verse
        //x  como en la siguiente imagen de ejemplo. 

        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;


        #region Constructores
        /// <summary>
        ///b.Constructor protegido.
        ///Inicializará el campo “codigo” con el método estático NewGuid de la clase Guid.
        ///Iniciar el resto de los campos con los parámetros de entrada.
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        protected Producto(string descripcion, double precio, int stock)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.Stock = stock;
        }
        #endregion
        #region Propiedades
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        /// <summary>
        /// c.La propiedad Stock de lectura y escritura.
        /// Validará que el stock ingresado sea mayor o igual a cero, sino no lo actualizará. 
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }
        #endregion
        /// <summary>
        /// e.Tiene un método de conversión explícito transforma un producto en su código. 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Guid(Producto p)
        {
           return p.codigo;
        }
        /// <summary>
        /// f.Sobrescribir el método ToString para devolver un string con los datos de un producto: 
        ///descripción, código, precio y stock.Se deberá utilizar StringBuilder y/o métodos de la clase
        ///String, no utilizar operador + y derivados (no concatenar).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDescripcion: {0}", this.Descripcion);
            sb.AppendFormat("\nCodigo: {0}", this.codigo);
            sb.AppendFormat("\nPrecio: {0}", this.Precio);
            sb.AppendFormat("\nStock: {0}", this.Stock);
            return sb.ToString();
        }

    }
}
