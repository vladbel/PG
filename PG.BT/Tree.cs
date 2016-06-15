using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.BT
{
    public class Tree
    {
        // traverse the tree and find max depth
        public static int MaxDepth (TreeNode root, int depth = 0)
        {
            if (root == null)
            {
                throw new NullReferenceException("Tree root can't be null");
            }
            return Math.Max(root.Left == null ? depth : MaxDepth(root.Left, depth + 1),
                            root.Right == null ? depth : MaxDepth(root.Right, depth + 1));
        }

        public static int MinDepth(TreeNode root, int depth = 0)
        {
            if (root == null)
            {
                throw new NullReferenceException("Tree root can't be null");
            }
            return Math.Min(root.Left == null ? depth : MinDepth(root.Left, depth + 1),
                            root.Right == null ? depth : MinDepth(root.Right, depth + 1));
        }

        public static bool IsBalanced ( TreeNode root)
        {
            return MaxDepth(root) - MinDepth(root) <= 1;
        }

        public static bool IsBinarySearchTree(TreeNode root)
        {
            return root.Left == null ? true : root.Value > MaxValue(root.Left) && IsBinarySearchTree(root.Left)
                && root.Right == null ? true : root.Value < MinValue(root.Right) && IsBinarySearchTree(root.Right);
        }

        public static int MaxValue (TreeNode root)
        {
            return Math.Max(root.Left == null ? root.Value : Math.Max(root.Value,MaxValue(root.Left)),
                            root.Right == null ? root.Value : Math.Max(root.Value, MaxValue(root.Right)));
        }

        public static int MinValue(TreeNode root)
        {
            return Math.Min(root.Left == null ? root.Value : Math.Min(root.Value, MinValue(root.Left)),
                            root.Right == null ? root.Value : Math.Min(root.Value, MinValue(root.Right)));
        }

        public static TreeNode BuildBalancedTreeFromArray (int[] array, int start = -1, int end = -1)
        {
            if (start == -1 && end == -1)
            {
                start = 0;
                end = array.Length - 1;
            }

            if (start == end)
            {
                return new TreeNode() { Value = array[start] };
            }
            else if (end < start)
            {
                return null;
            }
            else
            {
                var mid = (start + end) / 2;
                return new TreeNode()
                {
                    Value = array[mid],
                    Left = BuildBalancedTreeFromArray(array, start, mid-1),
                    Right = BuildBalancedTreeFromArray(array, mid+1, end)
                };
            }
        }
    }
}
