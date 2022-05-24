using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using ExcepcionesTorneo;
namespace UnitTestTorneo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JugarPartido_DeberiaJugarFecha1()
        {
            Torneo.ListaEquipos[0].Estadistica.PartJugados = 0;
            Torneo.JugarPartido(1);
            Assert.AreEqual(1, Torneo.ListaEquipos[0].Estadistica.PartJugados);

        }
        [TestMethod]
        [ExpectedException(typeof(ExcepcionFechaInvalida))]
        public void JugarPartido_DeberiaTirarExcepcionFechaInvalida()
        {
            Torneo.JugarPartido(-4);
        }
        [TestMethod]
        public void Estadistica_NoEsNull()
        {
            Torneo.JugarPartido(1);
            Assert.IsNotNull(Torneo.ListaEquipos[0].Estadistica);
        }
        [TestMethod]
        public void JugarPartido_DeberiaJugarFecha1_Success()
        {

            // Arrange -> inicializamos los datos desde donde vamos a probar 
            int nroFecha = 1;

            // Act -> Llamada a la funcionalidad a testiar

            Torneo.JugarPartido(nroFecha);

            // Assert -> Comprobacion de resultado: si lo esperamos es lo que obtuvimos. 

            Assert.IsNotNull(Torneo.ListaEquipos[0]);
            Assert.IsNull(null);

            Assert.AreEqual(nroFecha, Torneo.ListaEquipos[0].Estadistica.PartJugados);

        }

        [TestMethod]
        public void JugarPartido_DeberiaJugarFecha2_Sucess()
        {

            // Arrange -> inicializamos los datos desde donde vamos a probar 
            int nroFecha = 2;

            // Act -> Llamada a la funcionalidad a testiar

            Torneo.JugarPartido(nroFecha);

            // Assert -> Comprobacion de resultado: si lo esperamos es lo que obtuvimos. 

            Assert.IsNotNull(Torneo.ListaEquipos[0]);
            Assert.IsNull(null);

            Assert.AreEqual(nroFecha, Torneo.ListaEquipos[0].Estadistica.PartJugados);

        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        //[DataRow(-3)]  //// este va a fallar
        public void JugarPartido_DeberiaJugarFecha_Sucess(int nroFecha)
        {
            // Act -> Llamada a la funcionalidad a testiar
            Torneo.ListaEquipos[0].Estadistica.PartJugados = 0;
            Torneo.JugarPartido(nroFecha);

            // Assert -> Comprobacion de resultado: si lo esperamos es lo que obtuvimos. 

            Assert.AreEqual(1, Torneo.ListaEquipos[0].Estadistica.PartJugados);

        }
        [ExpectedException(typeof(ExcepcionFechaInvalida))]
        [TestMethod]
        public void JugarPartido_DeberiaFallar()
        {
            // Arrange -> inicializamos los datos desde donde vamos a probar 
            int nroFecha = -5;

            // Act -> Llamada a la funcionalidad a testiar

            Torneo.JugarPartido(nroFecha);

        }
    }
}
