using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    //13.    CentroDeAtencion:
    //x  Su único constructor instanciará ambos puestos de atencion y
    //x  será el encargado de agregar el manejador IngresarCliente al evento InformarCliente de GestorBD.
    //x  b.AbrirNegocio será la propiedad encargada de poner a leer los registros de la BD en un hilo secundario.
    //x     Implementar lo necesario de modo que se puede cerrar y abrir el negocio.
    //x  c.IngresarCliente verificara si el cliente requiere prioridad, y lo encolara en el puesto de atención que corresponda.
    //x      Luego de encolarlo informar el puesto de atención a través del evento.

    public class CentroDeAtencion
    {
        public delegate void DelegadoCaja(IAtendedor puestoDeAtencion);

        private CancellationTokenSource cancellationTokenSource;
        private string nombre;
        private PuestoNoPrioritario puestoNoPrioritario;
        private PuestoPrioritario puestoPrioritario;
        private Task tarea;
        public event DelegadoCaja InformarPuestoDeAtencion;
        public CentroDeAtencion()
        {
            this.cancellationTokenSource = new CancellationTokenSource();
            this.puestoPrioritario = new PuestoPrioritario();
            this.puestoNoPrioritario = new PuestoNoPrioritario();
            GestorBD.InformarCliente += this.IngresarCliente;
        }
        /// <summary>
        /// AbrirNegocio será la propiedad encargada de poner a leer los registros de la BD en un hilo secundario.
        /// </summary>
        public bool AbrirNegocio 
        {
            get
            {
                this.tarea = new Task(() =>
                {
                    GestorBD.ObtenerCliente(this.cancellationTokenSource.Token);
                });
                return true;
            }
            set
            {
                this.cancellationTokenSource.Cancel();
            } 
        }


        /// <summary>
        /// c.IngresarCliente verificara si el cliente requiere prioridad,
        /// y lo encolara en el puesto de atención que corresponda.
        ///  Luego de encolarlo informar el puesto de atención a través del evento.
        /// </summary>
        /// <param name="cliente"></param>
        private void IngresarCliente(Cliente cliente)
        {
            if(this.puestoPrioritario == cliente)
            {
                this.puestoPrioritario.FilaClientes.Enqueue(cliente);
                if (this.InformarPuestoDeAtencion != null)
                {
                    this.InformarPuestoDeAtencion.Invoke(this.puestoPrioritario);
                }
            }
            else
            {
                this.puestoNoPrioritario.FilaClientes.Enqueue(cliente);
                if (this.InformarPuestoDeAtencion != null)
                {
                    this.InformarPuestoDeAtencion.Invoke(this.puestoNoPrioritario);
                }
            }

        }
    }
}
