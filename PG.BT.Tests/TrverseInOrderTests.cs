using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PG.BT.Tests
{
    [TestClass]
    public class TrverseInOrderTests
    {
        [TestMethod]
        public void BuildList_From_BST_1_7()
        {
            // Setup
            var tree = TestTreeFactory.BST_1_7;

            var result = new List<TreeNode>();
            Action<TreeNode> processNode = (TreeNode n) =>
            {
                result.Add(n);
            };

            // Act
            Tree.TraverseInOrder(tree, processNode);

            // Assert
            for ( var i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i].Value,  i+1);
            }
        }

        [TestMethod]
        public void BuildLinkedList_From_BST_1_7()
        {
            // Setup
            var tree = TestTreeFactory.BST_1_7;

            TreeNode predicessor = null;

            Action<TreeNode> processNode = (TreeNode n) =>
            {
                if (predicessor != null)
                {
                    predicessor.Right = n;
                    n.Left = predicessor;
                }
                predicessor = n;
            };

            // Act
            Tree.TraverseInOrder(tree, processNode);

            // we are at the end of list now
            for (var i = 7; i > 0; i--)
            {
                Assert.AreEqual(predicessor.Value, i);
                predicessor = predicessor.Left;
            }

        }
    }
}
