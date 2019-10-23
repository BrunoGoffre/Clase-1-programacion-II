using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace Testeo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SeInstancia()
        {
            //Arrange
            Centralita centralita = new Centralita("Telefonica");
            //Assert
            Assert.IsNotNull(centralita.Llamadas);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void instance()
        {
            // new DivideByZeroException();
            Centralita centralita = new Centralita("Claro");
            centralita += new Local("111",20,"111",20);
            centralita += new Local("111", 20, "111", 20);
        }
    }
}
