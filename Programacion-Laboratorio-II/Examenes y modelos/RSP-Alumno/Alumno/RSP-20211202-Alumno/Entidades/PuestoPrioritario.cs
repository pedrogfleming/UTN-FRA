using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
//10.PuestoPrioritario:
//x  a.Implementa IAtendedor.
//x  b.Por defecto un puesto prioritario será de MAX_UNIDADES con 15 propductos.
//x  c.La propiedad NombrePuestoAtencion retornara "Puesto de atencion Prioritario de tipo [tipo]”
//x  d.La sobrecarga del operador  ==  comparara un PuestoPrioritario con un cliente para determinar si puede ser atendido por dicho puesto.
//x      Se retornará True si puesto es de tipo ANT_ESPECIAL y el cliente requiere prioridad, o si el tipo es MAX_UNIDADES y la cantidad de productos del cliente es menor a los permitidos en el puesto de atención.
//x  e.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.

//x     De lo contrario retira el primer cliente de la Queue y verifica si este puede ser atendido de forma prioritaria.
//x      En caso afirmativo retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.
//x      En caso negativo se lanzará una excepción ClienteNoAtendidoException. 

    public class PuestoPrioritario:IAtendedor
    {
        public enum ETipo { MAX_UNIDADES,ATN_ESPECIAL};
        private int cantProductos;
        private Queue<Cliente> filaClientes;
        private ETipo tipo;



        public PuestoPrioritario():this(ETipo.MAX_UNIDADES,15)
        {
        }
        public PuestoPrioritario(ETipo tipo,int cantProductos)
        {
            this.tipo = tipo;
            this.cantProductos = cantProductos;
            this.FilaClientes = new Queue<Cliente>();
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
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
        }
        /// <summary>
        /// c.La propiedad NombrePuestoAtencion retornara "Puesto de atencion Prioritario de tipo [tipo]”
        /// </summary>
        public string NombrePuestoAtencion
        {
            get
            {
                return "Puesto de atencion Prioritario de tipo " + this.tipo.ToString();
            }
        }
        /// <summary>
        /// e.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
        ///      De lo contrario retira el primer cliente de la Queue y verifica si este puede ser atendido de forma prioritaria.
        ///      En caso afirmativo retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.
        ///      En caso negativo se lanzará una excepción ClienteNoAtendidoException. 
        /// </summary>
        /// <returns></returns>
        public string AtenderClientes()
        {
            if (this.filaClientes.Count > 0)
            {
                Cliente c = this.filaClientes.Dequeue();
                if(c is not null && this == c)
                {
                    return "Cliente Atendido en " + this.NombrePuestoAtencion;
                }
                else
                {
                    throw new ClienteNoAtendidoException();
                }
            }
            return "Sin Clientes";
        }
        /// <summary>
        /// d.La sobrecarga del operador  ==  comparara un PuestoPrioritario con un cliente para determinar si puede ser atendido por dicho puesto.
        ///Se retornará True si puesto es de tipo ANT_ESPECIAL y el cliente requiere prioridad, 
        ///o si el tipo es MAX_UNIDADES y la cantidad de productos del cliente es menor a los permitidos en el puesto de atención.
        /// </summary>
        /// <param name="puesto"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator ==(PuestoPrioritario puesto,Cliente cliente)
        {
            if(puesto is not null && cliente is not null)
            {
                if(puesto.tipo == ETipo.ATN_ESPECIAL && cliente.Prioridad)
                {
                    return true;
                }
                return puesto.tipo == ETipo.MAX_UNIDADES && cliente.CantProductos < 15;
            }
            return false;
        }
        public static bool operator !=(PuestoPrioritario puesto, Cliente cliente)
        {
            return !(puesto == cliente);
        }
    }
}
