using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.BT.Tests
{
    [TestClass]
    public class BT_SumNodeValues_Tests
    {
        [TestMethod]
        public void BST_1_7_Test()
        {
            var root = TestTreeFactory.BST_1_7;
            var result = Tree.Sum(root);
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void BST_1_8_Test()
        {
            var root = TestTreeFactory.BST_1_8;
            var result = Tree.Sum(root);
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void BST_1_4_Test()
        {
            var root = TestTreeFactory.BST_1_4_NotBalanced;
            var result = Tree.Sum(root);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void BST_4_7_Test()
        {
            var root = TestTreeFactory.BST_4_7_NotBalanced;
            var result = Tree.Sum(root);
            Assert.AreEqual(22, result);
        }
    }
}
