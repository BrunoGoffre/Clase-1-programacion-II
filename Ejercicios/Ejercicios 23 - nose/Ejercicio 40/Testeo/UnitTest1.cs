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
    }
}
