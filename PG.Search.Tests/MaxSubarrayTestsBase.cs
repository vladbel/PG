using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PG.Search.Tests
{
    [TestClass]
    public abstract class MaxSubarrayTestsBase
    {
        protected Func<int[], List<int[]>> _findMaxSubarray;

        [TestMethod]
        public void ShallReturnFullArray_WhenAllElementsArePositive()
        {
            int[] array = { 3, 5, 1 };
            var result = _findMaxSubarray(array);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(3, result[0].Length);

            for ( var i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], result[0][i]);
            }
        }

        [TestMethod]
        public void ShallReturnFullArray_WhenContainsSingleElement()
        {
            int[] array = { 3};
            var result = _findMaxSubarray(array);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0].Length);

            for (var i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], result[0][i]);
            }
        }

        [TestMethod]
        public void ShallReturnFirstElement_WhenSecondIsNegative()
        {
            int[] array = { 3, -1 };
            var result = _findMaxSubarray(array);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0].Length);

           Assert.AreEqual(array[0], result[0][0]);

        }

        [TestMethod]
        public void ShallReturnSecondElement_WhenFirstIsNegative()
        {
            int[] array = { -1, 2 };
            var result = _findMaxSubarray(array);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0].Length);

            Assert.AreEqual(array[1], result[0][0]);
        }

        [TestMethod]
        public void ShallReturnSecondElement_WhenFirstAndThirdAreNegative()
        {
            int[] array = { -1, 2, -1};
            var result = _findMaxSubarray(array);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0].Length);

            Assert.AreEqual(array[1], result[0][0]);
        }

        public void ShallReturnArrayWithNegative_1()
        {
            int[] array = { 2,-1, 2, -1 };
            var result = _findMaxSubarray(array);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(3, result[0].Length);

            Assert.AreEqual(array[0], result[0][0]);
            Assert.AreEqual(array[1], result[0][1]);
            Assert.AreEqual(array[2], result[0][2]);
        }

        [TestMethod]
        public void ShallReturnArrayWithNegative_2()
        {
            int[] array = { -1, 2, -1, 2};
            var result = _findMaxSubarray(array);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(3, result[0].Length);

            Assert.AreEqual(array[1], result[0][0]);
            Assert.AreEqual(array[2], result[0][1]);
            Assert.AreEqual(array[3], result[0][2]);
        }

        [TestMethod]
        public void ShallReturnTwoArrays()
        {
            int[] array = {1, 2, -10, 3 };
            var result = _findMaxSubarray(array);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(2, result[0].Length);
            Assert.AreEqual(1, result[1].Length);

            Assert.AreEqual(array[0], result[0][0]);
            Assert.AreEqual(array[1], result[0][1]);
            Assert.AreEqual(array[3], result[1][0]);
        }
    }
}
