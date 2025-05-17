using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            string name = "Демьян";
            string result = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Демьян!", result);
        }
    }
}