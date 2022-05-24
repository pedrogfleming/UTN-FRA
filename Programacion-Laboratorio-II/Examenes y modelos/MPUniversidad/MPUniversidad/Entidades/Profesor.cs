using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        // X a.Antigüedad devolverá la cantidad de tiempo, en días, desde la fecha de ingreso del profesor hasta la actualidad.
        //b.ValidarDocumentacion dará como válido cuando el documento tenga exactamente 8 caracteres.

        private DateTime fechaIngreso;

        #region Constructor
        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento )
        {
        }

        public Profesor(string nombre,string apellido, string documento, DateTime fechaIngreso) : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Antigüedad devolverá la cantidad de tiempo, en días,
        ///desde la fecha de ingreso del profesor hasta la actualidad.
        /// </summary>
        public int Antiguedad
        {
            get
            {
                return (DateTime.Now - this.fechaIngreso).Days;
            }
        }
        #endregion
        #region 
        public override string ExponerDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine(base.ExponerDatos());
            aux.AppendFormat("\nFecha de ingreso: {0}", this.fechaIngreso);
            aux.AppendFormat("\nAntiguedad: {0}", this.Antiguedad);
            return aux.ToString();
        }
        #endregion
        protected override bool ValidarDocumentacion(string doc)
        {
            bool auxReturn = false;
            if ((!string.IsNullOrWhiteSpace(doc)) && doc.Length == 8)
            {
                foreach (char c in doc)
                {
                    if (!(char.IsDigit(c)))
                    {
                        return auxReturn;
                    }
                }
                auxReturn = true;
            }
            return auxReturn;
        }
    }
}