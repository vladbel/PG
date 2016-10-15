using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.LL.Tests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void Add_1_Plus_1()
        {
            var l1 = LinkedList<int>.Build(new int[] { 1 });
            var l2 = LinkedList<int>.Build(new int[] { 1 });

            var sum = LinkedList<int>.Add(l1, l2);
            Assert.AreEqual(2, sum.Value);
        }

        [TestMethod]
        public void Add_2_Plus_12()
        {
            var l1 = LinkedList<int>.Build(new int[] { 2 });
            var l2 = LinkedList<int>.Build(new int[] { 2, 1}); // note reverse order

            var sum = LinkedList<int>.Add(l1, l2);
            Assert.AreEqual(4, sum.Value);
            Assert.AreEqual(1, sum.Next.Value);
        }

        [TestMethod]
        public void Add_23_Plus_978()
        {
            var l1 = LinkedList<int>.Build(new int[] { 3, 2 });
            var l2 = LinkedList<int>.Build(new int[] { 8, 7,9 });

            var sum = LinkedList<int>.Add(l1, l2);
            Assert.AreEqual(1, sum.Value);
            Assert.AreEqual(0, sum.Next.Value);
            Assert.AreEqual(0, sum.Next.Next.Value);
            Assert.AreEqual(1, sum.Next.Next.Next.Value);
        }
    }
}
