using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.LL.Tests
{
    [TestClass]
    public class MultiplyWithShiftTests
    {
        [TestMethod]
        public void Test_12X2()
        {
            var lst = LinkedList<int>.Build(new int[] { 2, 1 }); // note reverse order

            var result = LinkedList<int>.Multiply(lst, 2, 0);

            Assert.AreEqual(4, result.Value);
            Assert.AreEqual(2, result.Next.Value);
        }

        [TestMethod]
        public void Test_12X20()
        {
            var lst = LinkedList<int>.Build(new int[] { 2, 1 }); // note reverse order

            var result = LinkedList<int>.Multiply(lst, 2, 1);

            Assert.AreEqual(0, result.Value);
            Assert.AreEqual(4, result.Next.Value);
            Assert.AreEqual(2, result.Next.Next.Value);
        }

        [TestMethod]
        public void Test_67X20()
        {
            var lst = LinkedList<int>.Build(new int[] { 7, 6 }); // note reverse order

            var result = LinkedList<int>.Multiply(lst, 2, 1);

            Assert.AreEqual(0, result.Value);
            Assert.AreEqual(4, result.Next.Value);
            Assert.AreEqual(3, result.Next.Next.Value);
            Assert.AreEqual(1, result.Next.Next.Next.Value);
        }
    }
}
