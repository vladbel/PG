using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.LL.Tests
{
    [TestClass]
    public class FindFromTailTests
    {
        [TestMethod]
        public void Find_1st_In_ListOf3()
        {
            var list = new LinkedListNode<int>()
            {
                Value = 0,
                Next = new LinkedListNode<int>()
                {
                    Value = 1,
                    Next = new LinkedListNode<int>()
                    {
                        Value = 2 ,
                        Next = null
                    }
                }
            };

            var result = LinkedList<int>.FindFromTail(list, 1);

            Assert.IsTrue(result.Value == 1);
        }

        [TestMethod]
        public void Find_2nd_In_ListOf3()
        {
            var list = LinkedList<int>.Build(new int[] {0, 1, 2 });
            var result = LinkedList<int>.FindFromTail(list, 2);
            Assert.IsTrue(result.Value == 0);

        }


        [TestMethod]
        public void Find_0_In_ListOf3()
        {
            var list = LinkedList<int>.Build(new int[] { 0, 1, 2 });
            var result = LinkedList<int>.FindFromTail(list, 0);
            Assert.IsTrue(result.Value == 2);

        }

        [TestMethod]
        public void Find_3_In_ListOf5()
        {
            var list = LinkedList<int>.Build(new int[] { 0, 1, 2, 3, 4 });
            var result = LinkedList<int>.FindFromTail(list, 3);
            Assert.IsTrue(result.Value == 1);

        }

        [TestMethod]
        public void Find_3_In_ListOf6()
        {
            var list = LinkedList<int>.Build(new int[] { 0, 1, 2, 3, 4, 5 });
            var result = LinkedList<int>.FindFromTail(list, 3);
            Assert.IsTrue(result.Value == 2);

        }
    }
}
