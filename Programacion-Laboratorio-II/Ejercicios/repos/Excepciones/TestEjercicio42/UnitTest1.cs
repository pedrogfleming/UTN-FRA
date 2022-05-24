using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;

namespace TestEjercicio42
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void OtraClaseConstructorMiExcepcion()
        {
            OtraClase auxOtraClase = new OtraClase();
        }
        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void MiClaseConstructor()
        {
            MiClase auxOtraClase = new MiClase();
        }
        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void AuxMiMetodoEstaticoExcepcion()
        {
            MiClase.miMetodoEstatico();
        }



    }
}
