using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace Testeo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SetInstance()
        {
            //Arrange
            Centralita centralita = new Centralita("Telefonica");
            //Assert
            Assert.IsNotNull(centralita.Llamadas);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LocalCall()
        {
            // new DivideByZeroException();
            Centralita centralita = new Centralita("Claro");
            centralita += new Local("111", 20, "111", 20);
            centralita += new Local("111", 20, "111", 20);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void ProvincialCall()
        {
            Centralita centralita = new Centralita("Personal");
            centralita += new Provincial("111", Provincial.Franja.Franja_1, 20, "222");
            centralita += new Provincial("111", Provincial.Franja.Franja_1, 20, "222");
        }
        [TestMethod]
        public void BothCalls()
        {
            int flag = 0;
            Centralita centralita = new Centralita("Movistar");
            try
            {
                centralita += new Provincial("111", Provincial.Franja.Franja_1, 20, "222");
                centralita += new Local("111", 20, "222", 30);
            }
            catch (CentralitaException a)
            {
                Assert.Fail();
            }
            try
            {
                 centralita += new Provincial("111", Provincial.Franja.Franja_1, 20, "222");
                 centralita += new Local("111", 20, "222", 30);
            }
            catch (CentralitaException a)
            {
                flag = 1;
            }
            if (flag == 0)
            {
                Assert.Fail();
            }
            
        }
    }
}
