using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint4.Task3.V17.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            // Arrange
            Class1 service = new Class1();

            // Создаем тестовый массив
            int[,] testArray = {
                {6, 4, 2, 2, 1},
                {3, 6, 5, 4, 1},
                {5, 2, 3, 1, 6},
                {8, 8, 4, 5, 3},
                {7, 4, 5, 1, 6}
            };

            // Ожидаемый результат: 13 (сумма четвертого столбца: 2+4+1+5+1)
            int expected = 13;

            // Act
            int actual = service.Calculate(testArray);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}