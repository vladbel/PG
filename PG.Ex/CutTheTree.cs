﻿using System;
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

            public bool Visited { get; set; }
            public bool PassSelfToParent { get; set; }

            public List<TreeNode> Children { get; private set; }

            public TreeNode Parent { get; set; }

            public TreeNode GetChild (int index)
            {
                return Children.Where(ch => ch.Index == index)?.FirstOrDefault();
            }

            public TreeNode(int index, int data)
            {
                Visited = false;
                PassSelfToParent = true;
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
                    var edge = input[i].Split(' ').Select(v => int.Parse(v)).ToArray();
                    this.AddEdge(edge[0], edge[1]);
                }
            }

            public void AddEdge (int index_1, int index_2)
            {
                var node_1 = Nodes.Where(n => n.Index == index_1)?.FirstOrDefault();
                var node_2 = Nodes.Where(n => n.Index == index_2)?.FirstOrDefault();
                node_1.Children.Add(node_2);
                node_2.Children.Add(node_1);
            }

            public int Traverse_R( TreeNode head)
            {
                if (head == null)
                {
                    return 0;
                }
                head.Visited = true;
                var result = head.Data;

                foreach(TreeNode n in head.Children)
                {
                    if ( !n.Visited)
                    {
                        result += Traverse_R(n);
                    }
                }

                head.SubtreeSum = result;
                return result;
            }

            public int Traverse (TreeNode head)
            {
                var stack = new Stack<TreeNode>();
                var current = head;
                current.Visited = true;

                Action<TreeNode> updateParent = (TreeNode node) =>
                {
                    if (node == null)
                    {
                        return;
                    }
                    var subtreeSumIncrement = node.Data;
                    node.PassSelfToParent = false;
                    var p = node?.Parent;
                    while (p != null)
                    {
                        p.SubtreeSum += subtreeSumIncrement;
                        if (p.PassSelfToParent)
                        {
                            p.PassSelfToParent = false;
                            subtreeSumIncrement += p.Data;
                        }
                        
                        p = p?.Parent;
                    }
                };

                while (current != null)
                {
                    var isLeaf = true;
                    current.Parent = current.Children.Where(n => n.Visited).FirstOrDefault();
                    current.SubtreeSum = current.Data;

                    foreach (TreeNode tn in current.Children)
                    {
                        if (!tn.Visited)
                        {
                            isLeaf = false; // node has children
                            tn.Visited = true;
                            tn.SubtreeSum = tn.Data;
                            stack.Push(tn);
                        }
                    }
                    if (isLeaf)
                    {
                        updateParent(current);
                    }
                    if (stack.Count > 0)
                    {
                        current = stack.Pop();
                    }
                    else
                    {
                        current = null;
                    }
                }

                return head.SubtreeSum;
            }

            public int FindClosest()
            {
                var max = Nodes.Where(n => n.Index == 1).FirstOrDefault().SubtreeSum;
                var closest = Nodes.Min( n => Math.Abs(max - 2 * n.SubtreeSum));
                return closest;
            }

        }
    }
}
