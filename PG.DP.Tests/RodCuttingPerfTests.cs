using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.DP.Tests
{
    [TestClass]
    public class RodCuttingPerfTests
    {
        [TestMethod]
        public void DP_ShallNot_BeCalled_MoreThenOnce()
        {
            var prices = new int[] { 0, 1, 1, 1, 1, 5 };
            var resultRecursive = RodCutting.Cut_Recurcive(5, prices, true);

            var resultDP = RodCutting.Cut_DP1(5, prices, true); ;

            for (var i = 0; i < 6; i++)
            {
                Assert.IsTrue(resultRecursive.Item2[i] >= resultDP.Item2[i]);
                Assert.IsTrue(resultDP.Item2[i] <= 1);
            }

        }
    }
}
