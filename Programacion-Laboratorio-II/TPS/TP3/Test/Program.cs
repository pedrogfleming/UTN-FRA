using System;
using Entidades;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = DateTime.Today;
            Instituto miInstituto = new Instituto("Instituto Derek Zoolander");
            #region Hardcodeo
            if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Borja", "Samantha", 34623863)))
            {
                if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Cruz", "Miguel", 98074835)))
                {
                    if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Lorenz", "Irma", 82183244)))
                    {
                        if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Letterman", "David", 70858336)))
                        {
                            if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Roberts", "Hugo", 64849969)))
                            {
                                if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Seinfeld", "Jerry", 95080161)))
                                {
                                    if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Kennedy", "John", 36323806)))
                                    {
                                        if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Numbela", "Thiago", 17512084)))
                                        {
                                            if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Peron", "Isabel", 97478202)))
                                            {
                                                if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Lopez", "Daniel", 55515082)))
                                                {
                                                    if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Penayo", "Isaac", 73287319)))
                                                    {
                                                        if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Valderrama", "Aurora", 30758655)))
                                                        {
                                                            if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Orozco", "Josefina", 68566175)))
                                                            {
                                                                if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Orozco", "Sabrina", 68566176)))
                                                                {
                                                                    if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Jolie", "Angelina", 94380896)))
                                                                    {
                                                                        if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Spears", "Britney", 63632686)))
                                                                        {
                                                                            if (miInstituto + (new Alumno(miInstituto.IdAlumnos, "Benitez", "Kevin", 45803665)))
                                                                            {
                                                                                Console.WriteLine("Se ha podido cargar con exito la lista de alumnos");
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (miInstituto + (new Curso(miInstituto.IdCursos, "Python", new DateTime(2010, 1, 1), new DateTime(2010, 3, 1), true)))
            {
                if (miInstituto + (new Curso(miInstituto.IdCursos, "Css", new DateTime(2014, 12, 1), new DateTime(2015, 3, 18), false)))
                {
                    if (miInstituto + (new Curso(miInstituto.IdCursos, "Maquetado Web", new DateTime(2018, 7, 26), new DateTime(2018, 9, 28), true)))
                    {
                        if (miInstituto + (new Curso(miInstituto.IdCursos, "Photoshop", new DateTime(2020, 4, 4), new DateTime(2020, 8, 4), true)))
                        {
                            if (miInstituto + (new Curso(miInstituto.IdCursos, "Cobol", new DateTime(1991, 10, 15), new DateTime(1992, 3, 22), true)))
                            {
                                Console.WriteLine("Se ha podido cargar con exito la lista de cursos");
                            }
                        }
                    }
                }
            }
            #endregion
            Curso c1 =new Curso(miInstituto.IdCursos, "Mantenimiento de Pc", new DateTime(2021, 12, 1), new DateTime(2022, 3, 25), false);
            Alumno a1 = new Alumno(miInstituto.IdAlumnos, "Gimenez", "Flavio", 22445566);
            if(c1+a1)
            {
                Console.WriteLine("Se ha cargado al alumno con exito");
            }
            else
            {
                Console.WriteLine("No se ha podido cargar al alumno al curso");
            }
            if(miInstituto-a1)
            {
                Console.WriteLine("Se ha eliminado al alumno del instituto con exito");
            }
            else
            {
                Console.WriteLine("No se ha podido eliminar al alumno del instituto");
            }
            if (miInstituto - c1)
            {
                Console.WriteLine("Se ha podido eliminar al curso del instituto con exito");
            }
            else
            {
                Console.WriteLine("No se ha podido eliminar al curso del instituto");
            }
            List<Curso> auxLista = new List<Curso>();
            auxLista = Curso.Informe_ObtenerEsLearning(miInstituto.Cursos, false);
            if(auxLista.Count > 0)
            {
                Console.WriteLine("Informe por cursos no E-Learning{0}",Instituto.ObtenerDatos(auxLista));
            }
            else
            {
                Console.WriteLine("No se han encontrado cursos no E-_Learning");
            }

        }
    }
}
