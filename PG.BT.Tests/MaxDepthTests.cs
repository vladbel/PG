using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.BT.Tests
{
    [TestClass]
    public class MaxDepthTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ShallThrowNullRefException_WhenTreeRootIsNull()
        {
            var result = Tree.MaxDepth(null);
        }

        [TestMethod]
        public void ShallHaveDepthOf_0_WhenLeftAndRightIsNull()
        {
            var tree = new Node();
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 0);
        }


        [TestMethod]
        public void ShallHaveDepthOf_1_WhenLeftAndRightIsNotNull()
        {
            var tree = new Node() { Left = new Node(), Right = new Node() };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 1);
        }

        [TestMethod]
        public void ShallHaveDepthOf_1_WhenLeftIsNull()
        {
            var tree = new Node() {Left = null, Right = new Node() };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 1);
        }

        [TestMethod]
        public void ShallHaveDepthOf_1_WhenRightIsNull()
        {
            var tree = new Node() { Left = new Node(), Right = null };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 1);
        }

        [TestMethod]
        public void ShallHaveDepthOf_2()
        {
            var tree = new Node() { Left = new Node() { Left = new Node(), Right = null}, Right = null };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 2);
        }
    }
}
