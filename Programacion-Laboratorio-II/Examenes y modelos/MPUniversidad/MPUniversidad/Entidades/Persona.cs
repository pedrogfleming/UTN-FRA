using System;
using System.Text;
namespace Entidades
{
    public abstract class Persona
    {
        //5. Tener en cuenta:
        //x a.ExponerDatos retornará los datos de la clase dónde se lo coloque, utilizando StringBuilder para
        //x compilar dicha información.
        //6. Tener en cuenta dentro de Persona:
        //x  a.ExponerDatos tendrá implementación en todas las clases y podrá ser sobre sobreescrita en las clases derivadas.
        //x  b.ValidarDocumentacion no tendrá implementación dentro de Persona.
        //x c.La propiedad Documento validará la documentación según corresponda.

        private string apellido;
        private string documento;
        private string nombre;

        #region Constructor
        public Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.Documento = documento;
            this.nombre = nombre;
        }
        #endregion
        #region Propiedades
        public string Apellido 
        {
            get
            {
                return this.apellido;
            }
        }
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if(ValidarDocumentacion(value)) 
                {
                    this.documento = value;
                }
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
        #region Metodos
        public virtual string ExponerDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("\nApellido: {0}", this.Apellido);
            aux.AppendFormat("\nNombre: {0}", this.Nombre);
            aux.AppendFormat("\nDocumento: {0}", this.Documento);
            return aux.ToString();
        }
        protected abstract bool ValidarDocumentacion(string doc);
        #endregion

    }
}
