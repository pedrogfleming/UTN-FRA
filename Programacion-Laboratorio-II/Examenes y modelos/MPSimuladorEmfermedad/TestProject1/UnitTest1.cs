using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GrupoDePrueba<Microrganismo>.InfectarPoblacion(null);
        }
    }
}
