using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class Curso
    {
        //x  a.El constructor privado será el único lugar donde se instanciará la lista de alumnos.
        //x  b.El operador explícito retornará los datos del curso y todos sus alumnos, utilizando StringBuilder para compilar dicha información.
        //x  c.El operador == entre Curso y Alumno informará true si el alumno pertenece al mismo Año y División que el curso.
        //x  d.El operador + entre Curso y Alumno agregará al alumno al curso siempre y cuando su Año y División coincidan.
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;


        #region Constructor
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        #endregion
        #region Propiedad
        public string AnioDivision
        {
            get
            {
                return this.anio + "°" + this.division.ToString();
            }
        }
        #endregion
        #region Sobrecargas == & !=
        /// <summary>
        /// informará true si el alumno pertenece al mismo Año y División que el curso.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Curso c,Alumno a)
        {
            if(c is not null && a is not null && c.AnioDivision == a.AnioDivision)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        #endregion
        #region Sobrecarga + Agregar alumno al curso
        /// <summary>
        /// El operador + entre Curso y Alumno agregará al alumno al curso siempre y cuando su Año y División coincidan.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c is not null && a is not null && c == a)
            {
                foreach (Alumno item in c.alumnos)
                {
                    if(item.Documento == a.Documento || (item.Apellido == a.Apellido && item.Nombre == a.Nombre))
                    {
                        return c;
                    }
                }
                c.alumnos.Add(a);
            }
            return c;
        }
        #endregion
        #region Sobrecargar explicitr operator obtener datos del curso y sus alumnos
        /// <summary>
        /// El operador explícito retornará los datos del curso y todos sus alumnos, utilizando StringBuilder para compilar dicha información.
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator string(Curso c)
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("\nCurso : {0}", c.AnioDivision);
            aux.AppendFormat("\nProfesor : {0}", c.profesor.ExponerDatos());
            aux.AppendLine("\nListado Alumnos: \n");
            foreach (Alumno item in c.alumnos)
            {
                aux.AppendFormat("\nAlumno : {0}", item.ExponerDatos());
            }
            return aux.ToString();
        }
        #endregion
    }
}
