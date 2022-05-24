using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;
using Files;
namespace TestProjectCajasClientes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ClienteNoAtendidoException))]
        public void ExcepcionClienteNoAtendido_Ok()
        {
            Cliente c = new("Juan", 16, false);
            PuestoPrioritario caja = new PuestoPrioritario();
            caja.FilaClientes.Enqueue(c);
            caja.AtenderClientes();
        }
        [TestMethod]
        public void LeerJson_Ok()
        {
            Cliente c = new("Juan", 16, false);

            JsonManager<Cliente>.Guardar("test.json", c);

            Cliente auxCliente = JsonManager<Cliente>.Leer("test.json");
            Assert.IsTrue(c.ToString() == auxCliente.ToString());
        }
    }
}
