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
            var tree = new TreeNode();
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 0);
        }


        [TestMethod]
        public void ShallHaveDepthOf_1_WhenLeftAndRightIsNotNull()
        {
            var tree = new TreeNode() { Left = new TreeNode(), Right = new TreeNode() };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 1);
        }

        [TestMethod]
        public void ShallHaveDepthOf_1_WhenLeftIsNull()
        {
            var tree = new TreeNode() {Left = null, Right = new TreeNode() };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 1);
        }

        [TestMethod]
        public void ShallHaveDepthOf_1_WhenRightIsNull()
        {
            var tree = new TreeNode() { Left = new TreeNode(), Right = null };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 1);
        }

        [TestMethod]
        public void ShallHaveDepthOf_2()
        {
            var tree = new TreeNode() { Left = new TreeNode() { Left = new TreeNode(), Right = null}, Right = null };
            var depth = Tree.MaxDepth(tree);
            Assert.IsTrue(depth == 2);
        }

        [TestMethod]
        public void ShallHaveDepthOf_3()
        {
            var t = TestTreeFactory.BST_1_8;
            var d = Tree.MaxDepth(t);
            Assert.AreEqual(3, d);

        }
    }
}
