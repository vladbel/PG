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
    }
}
