using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint4.Task0.V20.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task0.V20.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetMultEvenArrEl()
        {
            DataService task = new DataService();
            int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int expected = 24576;
            int actual = task.GetMultEvenArrEl(array);
            Assert.AreEqual(expected, actual);
        }
    }
}