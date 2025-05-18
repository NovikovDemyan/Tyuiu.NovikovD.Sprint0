using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NovikovD.Sprint0.Task7.V0.Lib;

namespace Tyuiu.NovikovD.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] expected = { 5, 7, 9 };
            int[] result = DataService.AdditionArrays(array1, array2);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}