using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PG.Ex;

namespace PG.Ex.Tests
{
    [TestClass]
    public class Ex_RearrangeArrayTests
    {

        [TestMethod]
        public void TestSwap_1_InArrayOf_10()
        {
            var a = new int[] { 0, 1, 2, 3, 4, 100, 101, 102, 103, 104 };
            RearrangeArray.Swap(1, a);
            Assert.AreEqual(1, a[2]); // next unarranged index - 3
        }

        [TestMethod]
        public void TestSwap_1_InArrayOf_12()
        {
            var a = new int[] { 0, 1, 2, 3, 4, 5, 100, 101, 102, 103, 104, 105 };
            RearrangeArray.Swap(1, a);
            Assert.AreEqual(1, a[2]); // all is sorted
        }

        [TestMethod]
        public void TestSwap_1_InArrayOf_16()
        {
            var a = new int[] {   0,   1,   2,   3,   4,   5,   6,   7,
                                100, 101, 102, 103, 104, 105, 106, 107 };
            RearrangeArray.Swap(1, a);
            Assert.AreEqual(1, a[2]);  // next unarranged index - 3
        }

        [TestMethod]
        public void TestSwap_1_InArrayOf_18()
        {
            var a = new int[] {   0,   1,   2,   3,   4,   5,   6,   7,   8,
                                100, 101, 102, 103, 104, 105, 106, 107, 108};
            RearrangeArray.Swap(1, a);
            Assert.AreEqual(1, a[2]);
        }


    }
}
