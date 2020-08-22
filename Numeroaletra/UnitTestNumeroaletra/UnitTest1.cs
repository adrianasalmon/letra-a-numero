using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeroaletra.Controllers;

namespace UnitTestNumeroaletra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumeroALetras()
        {
            //Arrange
            LiteralController literalController = new LiteralController();

            int a = 5;
            string esperado = "CINCO";

            //Act
            string resultado = literalController.LiteralGet(a);

            //Assert
            Assert.AreEqual(esperado, resultado);

        }

    }
}
