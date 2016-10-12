using PG.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.DP.Tests
{
    [TestClass]
    public class LongestSubarrayWhichAddsToGivenSumTests
    {
        [TestMethod]
        public void Test_1()
        {
            var array = new int[] { 1 };

            var result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 1);
            Assert.AreEqual(1, result);

            result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 2);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_2()
        {
            var array = new int[] { 1, 2};

            var result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 1);
            Assert.AreEqual(1, result);

            result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 2);
            Assert.AreEqual(1, result);

            result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 3);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void Test_3()
        {
            var array = new int[] { 1, -1, 1};

            var result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 1);
            Assert.AreEqual(3, result);

            result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 0);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_4()
        {
            var array = new int[] { 5, -1, 1, 0};

            var result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 5);
            Assert.AreEqual(4, result);

            result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 4);
            Assert.AreEqual(2, result);

            result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 0);
            Assert.AreEqual(3, result);

            result = LongestSubarray.LongestSubArrayThatAddsToTheGivenSum(array, 1);
            Assert.AreEqual(2, result);
        }
    }
}
