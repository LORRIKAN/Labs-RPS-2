using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1.Test
{
    [TestClass]
    public class ArrTest
    {
        [TestMethod]
        public void AllPositivesInArr()
        {
            int[] arr = { 57, 45, 78, 90, 3 };
            double expected = 54.6;
            double actual = Program.DoTask(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AllNegativesInArr()
        {
            int[] arr = { -85, -95, -67, -30, -37 };
            double expected = 62.8;
            double actual = Program.DoTask(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MixedArr()
        {
            int[] arr = { 87, -45, 90, 24, -3 };
            double expected = 49.8;
            double actual = Program.DoTask(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AllElems0()
        {
            int[] arr = { 0, 0, 0, 0, 0 };
            double expected = 0;
            double actual = Program.DoTask(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NullArr()
        {
            int[] arr = null;
            double expected = double.NaN;
            double actual = Program.DoTask(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}