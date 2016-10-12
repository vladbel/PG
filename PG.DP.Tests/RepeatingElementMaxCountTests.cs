using PG.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.DP.Tests
{
    [TestClass]
    public class RepeatingElementMaxCountTests
    {
        [TestMethod]
        public void Test_1()
        {
            var array = new int[] { 1, 2, 1 };

            var result = RepeatingElementMaxCount.Count(array);

            Assert.AreEqual(1, result.Item1); // element with max count value
            Assert.AreEqual(2, result.Item2); // count
        }

        [TestMethod]
        public void Test_2()
        {
            var array = new int[] { 1, 2, 1, 2 };

            var result = RepeatingElementMaxCount.Count(array);

            Assert.AreEqual(1, result.Item1); // element with max count value
            Assert.AreEqual(2, result.Item2); // count
        }

        [TestMethod]
        public void Test_3()
        {
            var array = new int[] { 1, 2, 1, 2, 2 };

            var result = RepeatingElementMaxCount.Count(array);

            Assert.AreEqual(2, result.Item1); // element with max count value
            Assert.AreEqual(3, result.Item2); // count
        }
    }
}
