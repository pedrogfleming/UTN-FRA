using Entidades;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testing
            //Curso c1 = new Curso(1,"C++",DateTime.Now,DateTime.Now.AddDays(55),true);
            //Curso c2 = new Curso(2, "Python", DateTime.Now, DateTime.Now.AddDays(51), false);
            //Curso c3 = new Curso(3, "Python", DateTime.Now, DateTime.Now.AddDays(12), true);
            //Curso c4 = new Curso(4, "Python", DateTime.Now, DateTime.Now.AddDays(33), false);
            //Curso c5 = new Curso(5, "Lua", DateTime.Now, DateTime.Now.AddDays(44), true);
            Alumno c1 = new Alumno(1, "Pedro", "Fleming", 39184453);
            Alumno c2 = new Alumno(2, "Luis", "Fleming", 28489602);
            Alumno c3 = new Alumno(3, "Gaspar", "Gimenez", 18483665);
            Alumno c4 = new Alumno(4, "Lily", "Smith", 22284416);
            Alumno c5 = new Alumno(5, "Dean", "Lopez", 11884001);
            List<Alumno> cursos = new List<Alumno>();
            cursos.Add(c1);
            cursos.Add(c2);
            cursos.Add(c3); 
            cursos.Add(c4);
            cursos.Add(c5);
            List<Alumno> cursosInforme = Instituto.prepararInforme(cursos, "dni", ">", "22284416");
             Console.WriteLine("Fin");
            #endregion
        }
    }
}
