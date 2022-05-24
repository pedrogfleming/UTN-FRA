using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        //Tener en cuenta dentro de Alumno:
        //x  a.ValidarDocumentacion dará como válido sólo documentos que tengan el siguiente formato
        //x         XX-XXXX-X siendo las X números.
        //Caso contrario retornará false y no se asignará el documento, siguiendo luego con el curso normal de la aplicación
        //x  La propiedad AnioDivision retornará un string con el siguiente formato:
        //x  XºZ, siendo X el año que se encuentra cursando y Z la división en letra
        //x  (A, B, C, D o E).
        private short anio;
        private Divisiones division;


        #region Constructor
        public Alumno(string nombre,string apellido, string documento, short anio, Divisiones divison)
            :base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = divison;
        }
        #endregion
        #region Propiedades
        public string AnioDivision 
        {
            get
            {
                return this.anio+"°"+this.division.ToString();
            }
        }

        #endregion
        #region Metodos
        public override string ExponerDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine(base.ExponerDatos());
            aux.AppendFormat("\n Anio y Division: {0}", this.AnioDivision);
            return aux.ToString();
        }
        /// <summary>
        /// ValidarDocumentacion dará como válido sólo documentos que tengan el siguiente formato:
        ///XX-XXXX-X siendo las X números.
        /// </summary>
        /// <returns>Caso contrario retornará false y no se asignará el documento</returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            if (!string.IsNullOrWhiteSpace(doc) &&  doc.Length == 9)
            {
                for (int i = 0; i < doc.Length - 1; i++)
                {
                    if ((i == 2 || i == 7) && doc[i] != '-')
                    {
                        return false;
                    }
                    else if (!char.IsDigit(doc[i]) && (i != 2 && i != 7))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        #endregion
    }
}
