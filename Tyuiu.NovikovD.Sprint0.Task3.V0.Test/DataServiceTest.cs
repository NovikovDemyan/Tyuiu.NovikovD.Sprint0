using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint0.Task3.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumValid()
        {
            int a = 5;
            int b = 10;
            int result = DataService.Sum(a, b);
            Assert.AreEqual(15, result); // Проверка: 5 + 10 = 15
        }
    }
}