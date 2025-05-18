using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint0.Task5.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(15, DataService.Addition(5, 10));
        }

        [TestMethod]
        public void CheckSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(15, 10));
        }

        [TestMethod]
        public void CheckMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(5, 10));
        }

        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(15, 5));
        }
    }
}