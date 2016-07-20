using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PG.DP.Tests
{
    [TestClass]
    public abstract class RodCuttingTests
    {

        protected Func< int, int[], Tuple<int, int, List<int>>> cutRod;

        [TestMethod]
        public void When_Length1()
        {
            var prices = new int[] { 0, 1, 2 };
            var result = cutRod(1, prices);

            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(1, result.Item3[0]);
        }

        [TestMethod]
        public void When_Length2()
        {
            var prices = new int[] { 0, 2, 3 };
            var result = cutRod(2, prices);

            Assert.AreEqual(4, result.Item1);
            Assert.AreEqual(1, result.Item3[0]);
            Assert.AreEqual(1, result.Item3[1]);
        }
    }
}
