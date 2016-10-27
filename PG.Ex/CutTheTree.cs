using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Ex
{
    /// <summary>
    /// from:https://www.hackerrank.com/challenges/cut-the-tree?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    ///  n-vertex tree, , where each vertex :
    ///  Is indexed with a unique integer from 1 to.
    ///  Contains a data value, .
    /// Anna observes that cutting any edge, ,
    /// in  results in the formation of two separate trees denoted by and.She also defines the following:
    ///    The sum of a tree is the sum of the TreeNode.Data values for all vertices in the tree.
    /// The difference between two trees created by cutting edge is denoted by: mod (sum(tree1) - sum(tree2))
    /// Given the definition of tree , remove some edge such that the value of difernce is minimal.
    /// Then print the value of the minimum possible  as your answer.
    ///    Note: The tree is always rooted at vertex 1.
    /// </summary>
    public class CutTheTree
    {
        class TreeNode
        {
            public int Index { get; set; }
            public int Data { get; set; }

            public List<TreeNode> Children { get; private set; }

            public TreeNode GetChild (int index)
            {
                return Children.Where(ch => ch.Index == index)?.FirstOrDefault();
            }

            public TreeNode(int index, int data)
            {
                Index = index;
                Data = data;
                Children = new List<TreeNode>();
            }
        }

        class Tree
        {
            public List<TreeNode> Nodes { get; private set; }

            public Tree()
            {
                Nodes = new List<TreeNode>();
            }

            public void AddEdge (int parent, int child)
            {
                var parentNode = Nodes.Where(n => n.Index == parent)?.FirstOrDefault();
                var childNode = Nodes.Where(n => n.Index == child)?.FirstOrDefault();
                parentNode.Children.Add(childNode);
            }
        }
    }
}
