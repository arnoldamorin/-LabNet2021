using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioExtensionesExcepciones.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionesExcepciones.Extensions.Tests
{
    [TestClass()]
    public class DoubleExtensionsTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            //arrange
            double dividendo = 88;
            double divisor = 5;
            double resultadoEsperado = 17.6;
            // act
            double resultado = dividendo.Dividir(divisor);

            //assert
            Assert.AreEqual(resultadoEsperado, resultado);            
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirTestPorCero()
        {
            //arrange
            double dividendo = 10;
            double divisor = 0;
            //act          
            double resultado = dividendo.Dividir(divisor);
            
            
        }

    }
}