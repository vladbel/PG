using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.Search.Tests
{
    [TestClass]
    public class MaxCrossSubarrayTests
    {
        [TestMethod]
        public void ShallReturn_0_0_ForArray_1()
        {
            var result = MaxSubarray.FindMaxCrossSubarray(array: new int[] { 1 },
                                                            low: 0,
                                                            mid: 0,
                                                            high: 0);
            Assert.AreEqual(0, result.Item1);
            Assert.AreEqual(0, result.Item2);
        }

        [TestMethod]
        public void ShallReturn_0_1_ForArray_1_2()
        {
            var result = MaxSubarray.FindMaxCrossSubarray(array: new int[] { 1, 2},
                                                            low: 0,
                                                            mid: 0,
                                                            high: 1);
            Assert.AreEqual(0, result.Item1);
            Assert.AreEqual(1, result.Item2);
        }

        [TestMethod]
        public void ShallReturn_1_1_ForArray_n1_1_n1()
        {
            var result = MaxSubarray.FindMaxCrossSubarray(array: new int[] { -1, 1, -1 },
                                                            low: 0,
                                                            mid: 1,
                                                            high: 2);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(1, result.Item2);
        }

        [TestMethod]
        public void ShallReturn_1_2_ForArray_n1_1_1_n1()
        {
            var result = MaxSubarray.FindMaxCrossSubarray(array: new int[] { -1, 1, 1, -1 },
                                                            low: 0,
                                                            mid: 1,
                                                            high: 3);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(2, result.Item2);

            result = MaxSubarray.FindMaxCrossSubarray(array: new int[] { -1, 1, 1, -1 },
                                                            low: 0,
                                                            mid: 2,
                                                            high: 3);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }

        [TestMethod]
        public void ShallReturn_1_3_ForArray_n1_1_2_3_n1()
        {
            var result = MaxSubarray.FindMaxCrossSubarray(array: new int[] { -1, 1, 2, 3, -1 },
                                                            low: 0,
                                                            mid: 2,
                                                            high: 4);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(3, result.Item2);
        }

        [TestMethod]
        public void ShallReturn_2_3_ForArray_1_n1_n1_3_n1()
        {
            var result = MaxSubarray.FindMaxCrossSubarray(array: new int[] { 1, -1, -1, 3, -1 },
                                                            low: 0,
                                                            mid: 2,
                                                            high: 4);
            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(3, result.Item2);
        }
    }
}
