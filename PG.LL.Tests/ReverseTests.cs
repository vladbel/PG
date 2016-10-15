using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.LL.Tests
{
    [TestClass]
    public class ReverseTests
    {

        [TestMethod]
        public void Test_1()
        {
            var list = LinkedList<int>.Build(new int[] { 1 });
            list = LinkedList<int>.Reverse(list);
            Assert.AreEqual(1, list.Value);
        }

        [TestMethod]
        public void Test_2()
        {
            var list = LinkedList<int>.Build(new int[] { 1, 2 });
            list = LinkedList<int>.Reverse(list);
            Assert.AreEqual(2, list.Value);
            Assert.AreEqual(1, list.Next.Value);
        }

        [TestMethod]
        public void Test_3()
        {
            var list = LinkedList<int>.Build(new int[] { 1, 2, 3 });
            list = LinkedList<int>.Reverse(list);
            Assert.AreEqual(3, list.Value);
            Assert.AreEqual(2, list.Next.Value);
            Assert.AreEqual(1, list.Next.Next.Value);
        }

        [TestMethod]
        public void Test_Empty()
        {
            var list = LinkedList<int>.Build(new int[] {});
            list = LinkedList<int>.Reverse(list);
            Assert.IsNull(list);
        }
    }
}
