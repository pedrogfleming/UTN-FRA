using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using System;

namespace TestTp3
{
    [TestClass]
    public class UnitTestInstituto
    {

        [TestMethod]
        public void VerificarIgualdadAlumnos_Ok()
        {
            Alumno a1 = new Alumno(0, "Borja", "Samantha", 34623863,19,Alumno.EGenero.femenino);
            Alumno a2 = new Alumno(0, "Cruz", "Miguel", 98074835,25,Alumno.EGenero.masculino);
            bool resultado;
            if(a1 == a2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarIgualdadCursos_Ok()
        {
            Instituto miInstituto = new Instituto("Instituto Derek Zoolander");
            Curso c1 = new Curso(miInstituto.IdCursos, "Python", new DateTime(2014, 12, 1), new DateTime(2010, 3, 1), true);
            Curso c2 = new Curso(miInstituto.IdCursos, "Css", new DateTime(2014, 12, 1), new DateTime(2015, 3, 18), false);
            bool resultado = c1 == c2;
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarInscribirAlumnoEnCurso_Ok()
        {
            Instituto miInstituto = new Instituto("Instituto Derek Zoolander");
            Alumno a1 = new Alumno(miInstituto.IdAlumnos, "Borja", "Samantha", 34623863, 19, Alumno.EGenero.femenino);
            _ = miInstituto + a1;
            Curso c1 = new Curso(miInstituto.IdCursos, "Python", new DateTime(2014, 12, 1), new DateTime(2010, 3, 1), true);
            _ = miInstituto + c1;
            bool resultado = c1 + a1;
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarInscribirAlumnoEnCurso_YaExisteAlumno()
        {
            Instituto miInstituto = new Instituto("Instituto Derek Zoolander");
            Alumno a1 = new Alumno(miInstituto.IdAlumnos, "Borja", "Samantha", 34623863, 19, Alumno.EGenero.femenino);
            Alumno a2 = new Alumno(miInstituto.IdAlumnos, "Cruz", "Miguel", 98074835, 25, Alumno.EGenero.masculino);
            _ = miInstituto + a1;
            Curso c1 = new Curso(miInstituto.IdCursos, "Python", new DateTime(2014, 12, 1), new DateTime(2010, 3, 1), true);
            _ = miInstituto + c1;
            _ = c1 + a1;
            bool resultado = c1 + a2;
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void VerificarQuitarAlumnoInstituto()
        {
            Instituto miInstituto = new Instituto("Instituto Derek Zoolander");
            Alumno a1 = new Alumno(miInstituto.IdAlumnos, "Borja", "Samantha", 34623863, 19, Alumno.EGenero.femenino);
            
            _ = miInstituto + a1;
            Alumno a2 = new Alumno(miInstituto.IdAlumnos, "Cruz", "Miguel", 98074835, 25, Alumno.EGenero.masculino);
            _ = miInstituto + a2;

            bool resultado = miInstituto - a1;
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarAlumnoMasJoven_Falla()
        {
            Instituto miInstituto = new Instituto("Instituto Derek Zoolander");
            Alumno a1 = miInstituto.AlumnoMasJoven();
            Assert.IsNull(a1);
        }

    }
}

