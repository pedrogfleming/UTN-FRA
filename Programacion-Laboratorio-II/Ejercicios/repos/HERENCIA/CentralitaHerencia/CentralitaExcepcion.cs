using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralitaExcepcion : Exception
    {
        /*Agregar la clase CentralitaException, la cual deriva de Exception.    x
            b. En el operador + de Centralita, lanzar la excepción CentralitaExcepction en el caso de que la
            llamada se encuentre registrada en el sistema.
            c. Capturar dicha excepción tanto en la versión para Consola como en la de Formularios y
            mostrar el mensaje de forma “amigable” al usuario.
         */
        private string nombreClase;
        private string nombreMetodo;
        #region Constructores
        public CentralitaExcepcion(string mensaje, string clase, string metodo):base(mensaje)
        {
        }
        public CentralitaExcepcion(string mensaje, string clase, string metodo,Exception innerException)
            :this(mensaje, clase, metodo)
        {
        }
        #endregion
        #region Propiedades
        public string NombreClase         
        {
            get
            {
                return this.nombreClase;
            }        
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        #endregion

    }
}
