using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PG.DP.Tests
{
    [TestClass]
    public abstract class RodCuttingTests
    {

        protected Func</*in:length =*/int, 
                       /*in:prices =*/int[],
                       /*in:reset =*/ bool,
                       /*out:*/Tuple<int, int[], List<int>>> cutRod;

        [TestMethod]
        public void When_Length1()
        {
            var prices = new int[] { 0, 1, 2 };
            var result = cutRod(1, prices, true);

            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(1, result.Item3[0]);
        }

        [TestMethod]
        public void When_Length2()
        {
            var prices = new int[] { 0, 2, 3 };
            var result = cutRod(2, prices, true);

            Assert.AreEqual(4, result.Item1);
            Assert.AreEqual(1, result.Item3[0]);
            Assert.AreEqual(1, result.Item3[1]);
        }

        [TestMethod]
        public void When_Length3()
        {
            var prices = new int[] { 0, 1, 3, 1 };
            var result = cutRod(3, prices, true);

            Assert.AreEqual(4, result.Item1);
            Assert.AreEqual(2, result.Item3.Count);
        }

        [TestMethod]
        public void When_Length4_Return_4x1()
        {
            var prices = new int[] { 0, 1, 1, 1, 1};
            var result = cutRod(4, prices, true);

            Assert.AreEqual(4, result.Item1);
            Assert.AreEqual(4, result.Item3.Count);
        }

        [TestMethod]
        public void When_Length4_Return_2x2()
        {
            var prices = new int[] { 0, 1, 3, 1, 1 };
            var result = cutRod(4, prices, true);

            Assert.AreEqual(6, result.Item1);
            Assert.AreEqual(2, result.Item3.Count);
        }

        [TestMethod]
        public void When_Length4_Return_1x4()
        {
            var prices = new int[] { 0, 1, 1, 1, 5 };
            var result = cutRod(4, prices, true);

            Assert.AreEqual(5, result.Item1);
            Assert.AreEqual(1, result.Item3.Count);
        }
    }
}
