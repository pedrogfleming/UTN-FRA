using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        //d.Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
        //los mismos datos de origen y destino.Luego comparar cada uno de estos cuatro objetos
        //contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial
        //entre sí.

        /// <summary>
        /// /a)Crear un test unitario que valide que la lista de llamadas de la centralita esté instanciada al
        ///crear un nuevo objeto del tipo Centralita.
        /// </summary>
        [TestMethod]      
        
        public void ListaLlamadasNoEsNull()
        {
            //Arrange
            Centralita testCentralita;
            //Act
            testCentralita = new Centralita("Telecom");
            //Assert
            Assert.IsNotNull(testCentralita.Llamadas);
        }

        /// <summary>
        /// b.Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        /// se lance al intentar cargar una segunda llamada
        /// con solamente los mismos datos de origen y
        /// destino de una llamada Local ya existente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepcion))]
        public void CentralitaExceptionLlamdaDuplicada()
        {
            Centralita testCentralita = new Centralita("Telecom");
            LLamada llamada1 = new Local("111", 4, "444", 46);
            LLamada llamada2 = new Local("111", 2, "444", 88);
            testCentralita += llamada1;
            testCentralita += llamada2;
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepcion))]
        ///c.Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        ///se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        ///destino de una llamada Provincial ya existente.
        public void CentralitaExceptionLlamadaProvincialDuplicada()
        {
            Centralita testCentralita = new Centralita("Telecom");
            LLamada llamada1 = new Provincial("111", Provincial.Franja.Franja_1, 2, "444");
            LLamada llamada2 = new Provincial("111",Provincial.Franja.Franja_1, 2, "444");
            testCentralita += llamada1;
            testCentralita += llamada2;
        }
        [TestMethod]
        ///d.Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
        ///los mismos datos de origen y destino.
        ///Luego comparar cada uno de estos cuatro objetos contra los demás,
        ///debiendo ser iguales solamente las instancias de Local y de Provincial entre sí.
        public void CentralitaExceptionLlamadaProvincial_Local_Duplicada()
        {
            Centralita testCentralita = new Centralita("Telecom");
            LLamada llamada1 = new Provincial("111", Provincial.Franja.Franja_1, 2, "444");
            LLamada llamada2 = new Provincial("111", Provincial.Franja.Franja_1, 2, "444");
            LLamada llamada3 = new Local("111", 4, "444", 46);
            LLamada llamada4 = new Local("111", 2, "444", 88);

            Assert.IsTrue(llamada1 == llamada2);
            Assert.IsFalse(llamada1 == llamada3);
            Assert.IsFalse(llamada1 == llamada4);

            Assert.IsFalse(llamada2 == llamada3);
            Assert.IsFalse(llamada2 == llamada4);

            Assert.IsTrue(llamada3 == llamada4);
        }


    }
}
