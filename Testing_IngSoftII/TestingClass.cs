using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaNegocio;

namespace Testing_IngSoftII
{
    [TestClass]
    public class TestingClass
    {
        [TestMethod]
        public void TestCalcularY()
        {
            double x = 2;
            double resultadoEsperado = 18;
            double y = 0;

            Logica logica = new Logica();
            y = logica.CalcularY(x);

            Assert.AreEqual(y, resultadoEsperado);
        }
    }
}
