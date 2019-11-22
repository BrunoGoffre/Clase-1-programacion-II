using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Archivo;
using Entidades;

namespace UnitTestProject1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void GuardarArchivo()
        {
            Xml<Planeta> xml = new Xml<Planeta>();
            Planeta hola = new Planeta();
            xml.Guardar("",hola);
        }
    }
}
