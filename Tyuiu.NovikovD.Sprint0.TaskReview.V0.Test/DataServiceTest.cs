using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalcValid()
        {
            DataService ds = new DataService();
            int x = 2, y = 3, z = 4;
            int result = ds.Calc(x, y, z);
            Assert.AreEqual(45, result); // (2+3+4)*5 = 45
        }
    }
}