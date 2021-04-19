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
    public class IntegerExtensionsTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            //arrange
            int dividendo = 10;
            int divisor = 2;
            int resultadoEsperado = 5;
            // act
            int resultado = dividendo.Dividir(divisor);

            //assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirTestPorCero()
        {
            //arrange
            int dividendo = 10;            
            //act
            int resultado = dividendo.Dividir(0);           
        }
    }
}