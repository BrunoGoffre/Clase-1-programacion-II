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
        public void Instance()
        {
            Centralita centralita = new Centralita("Bruno");
            centralita += new Local("origen",20,"destino",20);
            Local intento = new Local("origen", 20, "destino", 20);
        }

        [TestMethod]
        public void ValidacionNumerica()
        {

        }
    }
}
