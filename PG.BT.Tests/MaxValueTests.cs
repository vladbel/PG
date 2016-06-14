using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.BT.Tests
{
    [TestClass]
    public class MaxValueTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void MaxValue_ShallThrowNullRefException_WhenTreeRootIsNull()
        {
            var result = Tree.MaxValue(null);
        }

        [TestMethod]
        public void MaxValue_ShallBe_1()
        {
            var tree = new TreeNode() {  Left = null, Right = null, Value = 1};
            Assert.AreEqual(1, Tree.MaxValue(tree));
        }

        [TestMethod]
        public void MaxValue_ShallBe_2()
        {
            var tree = new TreeNode()
            {
                Left = new TreeNode()
                {
                    Left = null,
                    Right = null,
                    Value = 1
                },
                Right = new TreeNode()
                {
                    Left = null,
                    Right = null,
                    Value = 1
                },
                Value = 2
            };
            Assert.AreEqual(2, Tree.MaxValue(tree));
        }

        [TestMethod]
        public void MaxValue_ShallBe_3()
        {
            var tree = new TreeNode()
            {
                Left = new TreeNode()
                {
                    Left = new TreeNode()
                    {
                        Value = 3
                    },
                    Right = null,
                    Value = 1
                },
                Right = new TreeNode()
                {
                    Left = new TreeNode()
                    {
                        Value = 2
                    },
                    Right = new TreeNode()
                    {
                        Value = 2
                    },
                    Value = 1
                },
                Value = 2
            };
            Assert.AreEqual(3, Tree.MaxValue(tree));
        }


    }
}
