using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42_Biblioteca;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMyClassStaticMethod()
        {
            MiClase.StaticMethod();
        }
        
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestConstructorMyClass()
        {
            MiClase myClass = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestConstructorIntMyClass()
        {
            MiClase myClass = new MiClase(12);
        }

        [TestMethod]
        [ExpectedException(typeof(UnaEsepcion))]
        public void TestStaticMethodAnotherClass()
        {
            OtraClase.metodo();
        }
    }
}
