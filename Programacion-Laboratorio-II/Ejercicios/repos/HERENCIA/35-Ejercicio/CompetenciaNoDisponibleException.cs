using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Ejercicio
{
    public class CompetenciaNoDisponibleException : Exception
    {
        /*a. La sobreescritura del método ToString retornará un mensaje con el siguiente formato por líneas:
            i. "Excepción en el método {0} de la clase {1}:"
            ii. Mensaje propio de la excepción
            iii. Todos los InnerException con una tabulación ('\t').
            b. La excepción CompetenciaNoDisponibleExcepcion será lanzada dentro de == de Competencia y Vehículo con el mensaje "El vehículo no corresponde a la competencia",
            capturada dentro del operador + y vuelta a lanzar como una nueva excepción con el mensaje "Competencia incorrecta". 
            Utilizar innerExcepcion para almacenar la excepción original.
            c. Modificar el Main para agregar un Vehículo que no corresponda con la competencia,
            capturar la excepción y mostrar el error por pantalla. 
         */
        private string nombreClase;
        private string nombreMetodo;

        #region Constructor
        public CompetenciaNoDisponibleException(string mensaje, Exception innerEx) :base(mensaje,innerEx)
        {
        }
        public CompetenciaNoDisponibleException(string mensaje,string clase, string metodo):this(mensaje, clase, metodo,null)
        { 
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo,Exception innerException):base($" {mensaje} {clase} {metodo}", innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
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

        /// <summary>
        /// La sobreescritura del método ToString retornará un mensaje con el siguiente formato por líneas:
        /// i. "Excepción en el método {0} de la clase {1}:"
        /// ii.Mensaje propio de la excepción
        ///  iii.Todos los InnerException con una tabulación ('\t').
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //StringBuilder aux = new StringBuilder();
            //aux.AppendFormat("\nExcepción en el método {0} de la clase {1}:\n{2}", this.NombreMetodo, this.NombreClase, this.Message);
            ////Guardo la 1era InnerException
            //Exception exInner = this.InnerException;
            //while(exInner is not null)
            //{
            //    aux.AppendFormat("\nExcepción {0}:", exInner.Message);
            //    aux.AppendFormat("\t{0}",exInner);
            //    exInner = exInner.InnerException;
            //}    
            //return aux.ToString();
            StringBuilder data = new StringBuilder();
            //data.AppendFormat("Excepcion en el metodo {0} de la clase {1}\n", this.NombreMetodo, this.NombreClase);
            data.AppendFormat("Excepcion {0}\n", this.Message);
            data.AppendLine("Algo salio mal, revisa los detalles.");
            data.AppendLine($"Details: {this.InnerException}");
            return data.ToString(); 
        }
    }

}
