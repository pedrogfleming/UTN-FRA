using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //11.	PuestoNoPrioritario:
    //x  a.Implementa IAtendedor.
    //x  b.La propiedad NombrePuestoAtencion retornara "Puesto de atención No Prioritario”
    //x  c.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
    //x     De lo contrario retira el primer cliente de la Queue y retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.

    public class PuestoNoPrioritario : IAtendedor
    {

        private Queue<Cliente> filaClientes;

        public PuestoNoPrioritario()
        {
            FilaClientes = new Queue<Cliente>();
        }

        public Queue<Cliente> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
            set
            {
                this.filaClientes = value;
            }
                
        }


        /// <summary>
        /// b.La propiedad NombrePuestoAtencion retornara "Puesto de atención No Prioritario”
        /// </summary>
        public string NombrePuestoAtencion
        {
            get
            {
                return "Puesto de atencion No Prioritario";
            }
        }

        /// <summary>
        /// c.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
        /// De lo contrario retira el primer cliente de la Queue y retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.
        /// </summary>
        /// <returns></returns>
        public string AtenderClientes()
        {
            if(this.filaClientes.Count > 0)
            {
                this.filaClientes.Dequeue();
                return "Cliente Atendido en "+this.NombrePuestoAtencion;
            }
            return "Sin Clientes";
        }
    }
}
