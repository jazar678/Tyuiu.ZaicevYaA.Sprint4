using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint4.Task1.V18.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            // Arrange
            DataService service = new DataService();
            int[] array = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };
            int expected = 79;

            // Act
            int actual = service.Calculate(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}