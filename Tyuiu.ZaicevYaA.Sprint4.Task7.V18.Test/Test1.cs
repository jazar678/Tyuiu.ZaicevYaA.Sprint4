using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint4.Task7.V18.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            // Arrange
            Class1 service = new Class1();
            int rows = 5;
            int columns = 3;
            string inputValue = "145258749635789";
            int expected = 12288;

            // Act
            int actual = service.Calculate(rows, columns, inputValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}