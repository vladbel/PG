using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PG.BT.Tests
{
    [TestClass]
    public class BuildBalancedTreeFromArrayTests
    {
        [TestMethod]
        public void BuildFrom_EmptyArray()
        {
            var root = Tree.BuildBalancedTreeFromArray(new int[] {});
            Assert.IsNull(root);
        }

        [TestMethod]
        public void BuildFrom_Array_With_1_Element()
        {
            var root = Tree.BuildBalancedTreeFromArray(new int[] {3});
            Assert.AreEqual(3, root.Value);
            Assert.IsNull(root.Left);
            Assert.IsNull(root.Right);
        }

        [TestMethod]
        public void BuildFrom_Array_With_2_Element()
        {
            var root = Tree.BuildBalancedTreeFromArray(new int[] { 2, 3 });
            Assert.AreEqual(2, root.Value);
            Assert.IsNull(root.Left);
            Assert.AreEqual(3, root.Right.Value);
        }

        [TestMethod]
        public void BuildFrom_Array_With_3_Element()
        {
            var root = Tree.BuildBalancedTreeFromArray(new int[] { 1, 2, 3 });
            Assert.AreEqual(2, root.Value);
            Assert.AreEqual(1, root.Left.Value);
            Assert.AreEqual(3, root.Right.Value);
        }

        [TestMethod]
        public void BuildFrom_Array_With_4_Element()
        {
            var root = Tree.BuildBalancedTreeFromArray(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(2, root.Value);
            Assert.AreEqual(1, root.Left.Value);
            Assert.AreEqual(3, root.Right.Value);
            Assert.AreEqual(4, root.Right.Right.Value);
            Assert.IsNull(root.Right.Left);
        }
    }
}
