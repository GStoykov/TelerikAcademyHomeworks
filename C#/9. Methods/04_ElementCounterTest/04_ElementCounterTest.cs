using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
namespace _04_ElementCounterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForValue4()
        {
            int[] arr = { -5, 3, 4, 123, 43, -42, 82, 15, 0, 4, 2, 1, 11, 29, 54, 23 };
            int result = Program.Program.ElementCounter(4, arr);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestForValue1000()
        {
            int[] arr = { -5, 3, 4, 123, 43, -42, 82, 15, 0, 4, 2, 1, 11, 29, 54, 23 };
            int result = Program.Program.ElementCounter(1000, arr);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestForValue23()
        {
            int[] arr = { -5, 3, 4, 23, 43, -42, 82, 15, 0, 4, 2, 1, 11, 29, 54, 23 };
            int result = Program.Program.ElementCounter(23, arr);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestForValue11()
        {
            int[] arr = { -5, 3, 4, 123, 43, -42, 82, 15, 0, 4, 2, 1, 11, 29, 54, 23 };
            int result = Program.Program.ElementCounter(11, arr);
            Assert.AreEqual(1, result);
        }
    }
}
