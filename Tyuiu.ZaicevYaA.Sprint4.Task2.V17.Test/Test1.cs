using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            // Arrange
            Class1 service = new Class1();
            int[] array = { 3, 4, 5, 6, 7, 8, 9, 3, 4 };
            int expected = 945; // 3*5*7*9*3

            // Act
            int actual = service.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculateAllEven()
        {
            // Arrange
            Class1 service = new Class1();
            int[] array = { 4, 6, 8, 4, 6, 8, 4, 6, 8 };
            int expected = 0;

            // Act
            int actual = service.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}