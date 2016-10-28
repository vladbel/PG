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
        public static void ReadInputFromConsole()
        {
            var size = int.Parse(Console.ReadLine());
            var tree = new Tree();

            var values = Console.ReadLine().Split(' ').Select(v => int.Parse(v)).ToArray();

            for (int i = 1; i <= size; i++)
            {
                tree.Nodes.Add(new TreeNode(i, values[i - 1]));
            }

            for (var i = 1; i < size; i++)
            {
                var edge = Console.ReadLine().Split(' ').Select(v => int.Parse(v)).ToArray();
                tree.AddEdge(edge[0], edge[1]);
            }

            tree.Traverse(tree.Nodes[0]);
            var result = tree.FindClosest();

            Console.WriteLine(result.ToString());
        }

        public static void ReadInputFromConsoleToBuffer()
        {
            var size = int.Parse(Console.ReadLine());
            string[] buffer = new string[size + 1];
            buffer[0] = size.ToString();

            buffer[1] = Console.ReadLine();

            for (var i = 2; i < buffer.Length; i++)
            {
                buffer[i] = Console.ReadLine();
            }

            var tree = new Tree(buffer);

            tree.Traverse(tree.Nodes[0]);
            var result = tree.FindClosest();

            Console.WriteLine(result.ToString());
        }

        public static int Test( string[] buffer)
        {
            var tree = new Tree(buffer);

            tree.Traverse(tree.Nodes[0]);
            var result = tree.FindClosest();
            return result;
        }
        class TreeNode
        {
            public int Index { get; set; }
            public int Data { get; set; }

            public int SubtreeSum { get; set; }

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

            public Tree( string[] input): this()
            {
                var size = int.Parse(input[0]);

                var values = input[1].Split(' ').Select(v => int.Parse(v)).ToArray();

                for (int i = 1; i <= size; i++)
                {
                    Nodes.Add(new TreeNode(i, values[i - 1]));
                }

                for (var i = 2; i < input.Length; i++)
                {
                    var edge = Console.ReadLine().Split(' ').Select(v => int.Parse(v)).ToArray();
                    this.AddEdge(edge[0], edge[1]);
                }
            }

            public void AddEdge (int parent, int child)
            {
                var parentNode = Nodes.Where(n => n.Index == parent)?.FirstOrDefault();
                var childNode = Nodes.Where(n => n.Index == child)?.FirstOrDefault();
                parentNode.Children.Add(childNode);
            }

            private Tuple<int, int>[] _subtreeSums;

            public int Traverse( TreeNode head)
            {
                if (head == null)
                {
                    return 0;
                }

                var result = head.Data;

                foreach(TreeNode n in head.Children)
                {
                    result += Traverse(n);
                }

                head.SubtreeSum = result;

                return result;
            }

            public int FindClosest()
            {
                var max = Nodes.Where(n => n.Index == 1).FirstOrDefault().Index;
                var closest = Nodes.Min( n => max - 2 * n.SubtreeSum);
                return closest;
            }

        }
    }
}
