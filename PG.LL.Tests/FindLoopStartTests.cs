using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.LL.Tests
{
    [TestClass]
    public class FindLoopStartTests
    {
        [TestMethod]
        public void Find_LoopStart_At_3_InListOf_6()
        {
            var head = LinkedList<int>.Build(new int[] { 0, 1, 2, 3, 4, 5 });
            var loopStart = LinkedList<int>.FindFromTail(head, 2);
            var tail = LinkedList<int>.GetTail(head);
            tail.Next = loopStart;

            Assert.IsTrue(loopStart.Value == 3);
            Assert.IsTrue(tail.Value == 5);

            var loopStartToTest = LinkedList<int>.FindLoopStart(head);
            Assert.IsTrue(loopStartToTest.Value == 3);
        }

        [TestMethod]
        public void Find_LoopStart_At_2_InListOf_6()
        {
            var head = LinkedList<int>.Build(new int[] { 0, 1, 2, 3, 4, 5 });
            var loopStart = LinkedList<int>.FindFromTail(head, 3);
            var tail = LinkedList<int>.GetTail(head);
            tail.Next = loopStart;

            Assert.IsTrue(loopStart.Value == 2);
            Assert.IsTrue(tail.Value == 5);

            var loopStartToTest = LinkedList<int>.FindLoopStart(head);
            Assert.IsTrue(loopStartToTest.Value == 2);
        }

        [TestMethod]
        public void Find_LoopStart_At_0_InListOf_6()
        {
            var head = LinkedList<int>.Build(new int[] { 0, 1, 2, 3, 4, 5 });
            var tail = LinkedList<int>.GetTail(head);
            tail.Next = head;

            Assert.IsTrue(tail.Value == 5);

            var loopStartToTest = LinkedList<int>.FindLoopStart(head);
            Assert.IsTrue(loopStartToTest.Value == 0);
        }
    }
}
