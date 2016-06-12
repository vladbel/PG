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
            var head = Node<int>.Build<int>(new int[] { 0, 1, 2, 3, 4, 5 });
            var loopStart = Node<int>.FindFromTail<int>(head, 2);
            var tail = Node<int>.GetTail(head);
            tail.Next = loopStart;

            Assert.IsTrue(loopStart.Value == 3);
            Assert.IsTrue(tail.Value == 5);

            var loopStartToTest = Node<int>.FindLoopStart(head);
            Assert.IsTrue(loopStartToTest.Value == 3);
        }

        [TestMethod]
        public void Find_LoopStart_At_2_InListOf_6()
        {
            var head = Node<int>.Build<int>(new int[] { 0, 1, 2, 3, 4, 5 });
            var loopStart = Node<int>.FindFromTail<int>(head, 3);
            var tail = Node<int>.GetTail(head);
            tail.Next = loopStart;

            Assert.IsTrue(loopStart.Value == 2);
            Assert.IsTrue(tail.Value == 5);

            var loopStartToTest = Node<int>.FindLoopStart(head);
            Assert.IsTrue(loopStartToTest.Value == 2);
        }

        [TestMethod]
        public void Find_LoopStart_At_0_InListOf_6()
        {
            var head = Node<int>.Build<int>(new int[] { 0, 1, 2, 3, 4, 5 });
            var tail = Node<int>.GetTail(head);
            tail.Next = head;

            Assert.IsTrue(tail.Value == 5);

            var loopStartToTest = Node<int>.FindLoopStart(head);
            Assert.IsTrue(loopStartToTest.Value == 0);
        }
    }
}
