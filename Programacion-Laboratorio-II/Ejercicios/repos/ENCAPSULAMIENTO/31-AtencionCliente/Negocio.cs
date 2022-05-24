using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_AtencionCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        #region Constructores
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new(Puesto.Caja1);
        }
        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }
        #endregion
        #region Propiedades
        public Cliente Cliente
        {
            get
            {
                if(clientes.Count > 0 )
                {
                    return clientes.Dequeue();
                }
                return null;
            }
            set
            {
                bool rta = (this + value);                 
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion
        #region Sobrecarga == & != Cliente esta incluido en el negocio
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if(c == item)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        #endregion
        #region Sobrecarga + Agregar cliente y proximo cliente
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                int numeroActual;
                n.clientes.Enqueue(c);
                numeroActual = PuestoAtencion.NumeroActual;
                return true;
            }
            return false;
        }
        /// <summary>
        /// El operador ~(Negocio) : bool generará una atención del próximo cliente en la cola,
        /// utilizando la propiedad Cliente y el método Atender de PuestoAtencion.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Retornará True si pudo realizar la operación completa.</returns>
        public static bool operator ~(Negocio n)
        {
            Cliente auxCliente =  n.Cliente;
            if(auxCliente is not null)
            {
                return n.caja.Atender(auxCliente);
            }
            return false;                       
        }
        #endregion

    }
}
