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
            RearrangeArray.Swap(3, a);
            Assert.AreEqual(1, a[2]);
        }

        [TestMethod]
        public void TestShuffle_InArrayOf_2x2()
        {
            var a = BuildArray(2);
            RearrangeArray.ShuffleHalves(a);
            ValidateArray(a);
        }

        [TestMethod]
        public void TestShuffle_InArrayOf_3x2()
        {
            var a = BuildArray(3);
            RearrangeArray.ShuffleHalves(a);
            ValidateArray(a);
        }

        [TestMethod]
        public void TestShuffle_InArrayOf_7x2()
        {
            var a = BuildArray(7);
            RearrangeArray.ShuffleHalves(a);
            ValidateArray(a);
        }

        [TestMethod]
        public void TestShuffle()
        {
            for (var i = 4; i < 100; i++)
            {
                var a = BuildArray(i);
                RearrangeArray.ShuffleHalves(a);
                ValidateArray(a);
            }
        }




        private int[] BuildArray (int size)
        {
            var a = new int[2 * size];

            for (var i = 0; i < size; i++)
            {
                a[i] = i;
                a[size + i] = 100 + i;
            }
            return a;
        }

        private void ValidateArray ( int[] a)
        {
            for (var i = 0; i < a.Length; i += 2 )
            {
                Assert.AreEqual(i / 2, a[i], "Fail in array of " + a.Length.ToString());
                Assert.AreEqual(i / 2 + 100, a[i + 1], "Fail in array of " + a.Length.ToString());
            }
        }




    }
}
