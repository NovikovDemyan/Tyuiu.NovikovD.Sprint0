using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint0.Task6.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(15, DataService.AdditionArray(nums));
        }

        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            int[] nums = { 10, 5, 3 };
            Assert.AreEqual(2, DataService.SubtractionArray(nums));
        }

        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            int[] nums = { 2, 3, 4 };
            Assert.AreEqual(24, DataService.MultiplicationArray(nums));
        }
    }
}