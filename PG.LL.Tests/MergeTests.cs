using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.LL.Tests
{
    [TestClass]
    public class MergeTests
    {
        [TestMethod]
        public void Test_1()
        {
            var list1 = LinkedList<int>.Build(new int[] { 2, 4 });
            var list2 = LinkedList<int>.Build(new int[] { 1, 3 });

            var merged = LinkedList<int>.Merge(list1, list2);

            for (var i = 1; i <=4; i++)
            {
                Assert.AreEqual(i, merged.Value);
                merged = merged.Next;
            }
        }

        [TestMethod]
        public void Test_2()
        {
            var list1 = LinkedList<int>.Build(new int[] { 2, 4, 5 });
            var list2 = LinkedList<int>.Build(new int[] { 1, 3, 6 });

            var merged = LinkedList<int>.Merge(list1, list2);

            for (var i = 1; i <= 6; i++)
            {
                Assert.AreEqual(i, merged.Value);
                merged = merged.Next;
            }
        }
    }
}
