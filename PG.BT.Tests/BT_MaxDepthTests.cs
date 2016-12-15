using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.BT.Tests
{
    [TestClass]
    public class BT_MaxDepthTests
    {
        [TestMethod]
        public void ShallReturn_0_WhenTreeRootIsNull()
        {
            Assert.AreEqual(0, Tree.MaxDepth(null));
        }

        [TestMethod]
        public void ShallHaveDepthOf_1_WhenLeftAndRightIsNull()
        {
            var tree = new TreeNode();
            var depth = Tree.MaxDepth(tree);
            Assert.AreEqual(1, depth);
        }


        [TestMethod]
        public void ShallHaveDepthOf_2_WhenLeftAndRightIsNotNull()
        {
            var tree = new TreeNode() { Left = new TreeNode(), Right = new TreeNode() };
            var depth = Tree.MaxDepth(tree);
            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void ShallHaveDepthOf_2_WhenLeftIsNull()
        {
            var tree = new TreeNode() {Left = null, Right = new TreeNode() };
            var depth = Tree.MaxDepth(tree);
            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void ShallHaveDepthOf_2_WhenRightIsNull()
        {
            var tree = new TreeNode() { Left = new TreeNode(), Right = null };
            var depth = Tree.MaxDepth(tree);
            Assert.AreEqual(2, depth);
        }

        [TestMethod]
        public void ShallHaveDepthOf_3()
        {
            var tree = new TreeNode() { Left = new TreeNode() { Left = new TreeNode(), Right = null}, Right = null };
            var depth = Tree.MaxDepth(tree);
            Assert.AreEqual(3, depth);
        }

        [TestMethod]
        public void ShallHaveDepthOf_4()
        {
            var t = TestTreeFactory.BST_1_8;
            var d = Tree.MaxDepth(t);
            Assert.AreEqual(4, d);

        }
    }
}
