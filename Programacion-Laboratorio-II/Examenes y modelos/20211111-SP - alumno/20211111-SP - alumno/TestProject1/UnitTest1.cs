using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GuardarArchivo_Ok()
        {
            object elementoVisual = new object();
            Juego j = new Juego(4, elementoVisual);
            JsonFiler<Juego> jf = new JsonFiler<Juego>();
            jf.Guardar("testJuego.json",j);
            Juego auxJuego;
            jf.Leer("testJuego.json", out auxJuego);
            Assert.AreEqual(j.Ubicacion, auxJuego.Ubicacion);
        }
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void ValidarExcepcion()
        {
            object elementoVisual = new object();
            Juego j = new(4, elementoVisual);
            JsonFiler<Juego> jf = new JsonFiler<Juego>();
            jf.Guardar("   ", j);
        }
        //[TestMethod]
        //public void ComprobarCancelattionToken_Ok()
        //{
        //    object elementoVisual = new object();
        //    Juego j = new(4, elementoVisual);
        //    CancellationTokenSource source = new CancellationTokenSource();
        //    CancellationToken token = source.Token;
        //    Action<CancellationToken> ac = new Action<CancellationToken>(j.IniciarCarrusel);
        //    Task myTask = new Task(ac);
        //    myTask.Start();
        //    source.Cancel();
        //    Assert.IsTrue(myTask.IsCanceled);
        //}
    }
}
