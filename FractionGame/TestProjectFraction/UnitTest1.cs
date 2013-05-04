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

        [TestMethod]
        public void testSumarFracciones()
        {
            Fraccion F1 = new Fraccion(2, 3);
            Fraccion F2 = new Fraccion(1, 3);

            Fraccion FraccionExpected = new Fraccion(3, 3);
            Fraccion resultado = new Fraccion();
            resultado.sumar(F1, F2);

            bool b = (resultado.Numerador == 3) && (resultado.Denominador == 3);
            Assert.AreEqual(true, b);

            //No existe esa clase dentro de VS, por ende, no interpreta el contenido y siempre daria False, compara las referencias
            //Assert.AreEqual(resultado, FraccionExpected);
        }

        [TestMethod]
        public void DenominadorNoCero()
        {
            //Evaluar que envie Excepcion
            Fraccion F = new Fraccion();
            try
            {
                F.Denominador = 0;
            }
            catch (DivideByZeroException D)
            {
                return;
            }

            Assert.Fail();
        }

    }
}
