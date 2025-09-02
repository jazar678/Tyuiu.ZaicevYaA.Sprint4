using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint4.Task5.V1.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            // Arrange
            Class1 service = new Class1();

            // Создаем тестовый массив 5x5
            int[,] testMatrix = {
                {-5,  3, -2,  7,  0},
                { 4, -1,  6, -8,  2},
                { 0, -3,  1,  5, -4},
                {-7,  8, -6,  0,  9},
                { 3, -2,  4, -1, -5}
            };

            // Ожидаемый результат
            int[,] expectedMatrix = {
                {-5,  1, -2,  1,  0},
                { 1, -1,  1, -8,  1},
                { 0, -3,  1,  1, -4},
                {-7,  1, -6,  0,  1},
                { 1, -2,  1, -1, -5}
            };

            // Act
            int[,] actualMatrix = service.Calculate(testMatrix);

            // Assert
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], actualMatrix[i, j]);
                }
            }
        }
    }
}