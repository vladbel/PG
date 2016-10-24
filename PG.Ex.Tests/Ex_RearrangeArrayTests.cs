using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PG.Ex;

namespace PG.Ex.Tests
{
    [TestClass]
    public class Ex_RearrangeArrayTests
    {

        [TestMethod]
        public void TestSwap_1()
        {
            var a = new int[] { 0, 1, 2, 3, 100, 101, 102, 103 };
            RearrangeArray.Swap(1, a);

            Assert.AreEqual(1, a[2]);

        }


    }
}
