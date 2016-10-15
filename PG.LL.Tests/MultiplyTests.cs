using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.LL.Tests
{
    [TestClass]
    public class MultiplyTests
    {
        [TestMethod]
        public void Test_12x12()
        {
            var l1 = LinkedList<int>.Build(new int[] { 2, 1 });
            var l2 = LinkedList<int>.Build(new int[] { 2, 1 }); // note reverse order

            var r = LinkedList<int>.Multiply(l1, l2);

            Assert.AreEqual(4, r.Value);
            Assert.AreEqual(4, r.Next.Value);
            Assert.AreEqual(1, r.Next.Next.Value);

        }
    }
}
