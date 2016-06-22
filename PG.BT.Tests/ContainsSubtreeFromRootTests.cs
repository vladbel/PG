using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.BT.Tests
{
    [TestClass]
    public class ContainsSubtreeFromRootTests
    {
        [TestMethod]
        public void ShallContainSubtree_01()
        {
            TreeNode tree = Tree.BuildBalancedTreeFromArray(new int[] {0, 1, 2, 3, 4, 5, 6});
            TreeNode subTree = Tree.BuildBalancedTreeFromArray(new int[] { 1, 3, 5 });
            Assert.IsTrue(Tree.ContainSubtreeFromRoot(tree, subTree));
        }

        [TestMethod]
        public void ShallContainSubtree_02()
        {
            TreeNode tree = Tree.BuildBalancedTreeFromArray(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            TreeNode subTree = Tree.BuildBalancedTreeFromArray(new int[] { 3 });
            Assert.IsTrue(Tree.ContainSubtreeFromRoot(tree, subTree));
        }

        [TestMethod]
        public void ShallContainSubtree_03()
        {
            TreeNode tree = Tree.BuildBalancedTreeFromArray(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            TreeNode subTree = new TreeNode() { Value = 3,
                                                Left = new TreeNode() { Value = 1 } };
            Assert.IsTrue(Tree.ContainSubtreeFromRoot(tree, subTree));
        }

        [TestMethod]
        public void ShallContainSubtree_04()
        {
            TreeNode tree = Tree.BuildBalancedTreeFromArray(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            TreeNode subTree = new TreeNode()
            {
                Value = 3,
                Right = new TreeNode() { Value = 5 }
            };
            Assert.IsTrue(Tree.ContainSubtreeFromRoot(tree, subTree));
        }

        [TestMethod]
        public void Shall_Not_ContainSubtree_01()
        {
            TreeNode tree = Tree.BuildBalancedTreeFromArray(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            TreeNode subTree = Tree.BuildBalancedTreeFromArray(new int[] { 0, 3, 5 });
            Assert.IsFalse(Tree.ContainSubtreeFromRoot(tree, subTree));
        }

        [TestMethod]
        public void Shall_Not_ContainSubtree_02()
        {
            TreeNode tree = Tree.BuildBalancedTreeFromArray(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            TreeNode subTree = new TreeNode()
            {
                Value = 3,
                Left = new TreeNode() { Value = 5 }
            };
            Assert.IsFalse(Tree.ContainSubtreeFromRoot(tree, subTree));
        }
    }
}
