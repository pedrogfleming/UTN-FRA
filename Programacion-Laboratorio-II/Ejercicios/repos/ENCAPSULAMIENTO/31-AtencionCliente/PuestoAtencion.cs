using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _31_AtencionCliente
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        #region Constructores
        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;

        }
        #endregion
        #region Propiedades
        public static int NumeroActual 
        {
            get
            {
                return numeroActual++;
            }    
        }
        #endregion
        /// <summary>
        /// El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, 
        /// simulará un tiempo de atención mediante el método de clase Sleep de la clase Thread
        /// </summary>
        /// <param name="cli"></param>
        /// <returns> Retornará true para indicar el final de la atención.</returns>
        public bool Atender(Cliente cli)
        {

            System.Threading.Thread.Sleep(1000);

            return true;
        }


         
    } 
}
