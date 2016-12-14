using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PG.BT;

namespace PG.BT.Tests
{
    [TestClass]
    public class BT_BstTests
    {
        [TestMethod]
        public void Test_1()
        {
            var tree = TestTreeFactory.BST_1_7;
            Assert.IsTrue(Tree.IsBinarySearchTree(tree));
        }

        [TestMethod]
        public void Test_2()
        {
            var tree = TestTreeFactory.InvalidBST_1_7;
            Assert.IsFalse(Tree.IsBinarySearchTree(tree));
        }
    }
}
S