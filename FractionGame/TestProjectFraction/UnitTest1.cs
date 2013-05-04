using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionGame;

namespace TestProjectFraction
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestconstructorDefault()
        {
            Fraccion F = new Fraccion();
            int numerador = F.Numerador;
            int denominador = F.Denominador;

            bool b = (numerador == 1) && (denominador == 1);
            Assert.AreEqual(true, b);
        }
    }
}
