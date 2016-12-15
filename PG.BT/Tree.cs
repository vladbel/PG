using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.BT
{
    public class Tree
    {
        public static int Sum ( TreeNode root)
        {
            if (root == null)
                return 0;
            else
                return Sum(root.Left) + Sum(root.Right) + root.Value;
        }

        // traverse the tree and find max depth
        public static int MaxDepth (TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max( MaxDepth(root.Left) + 1,
                             MaxDepth(root.Right) + 1);
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
        
        public static bool IsBinarySearchTree1(TreeNode root)
        {
            return root.Left == null ? true : root.Value > MaxValue(root.Left) && IsBinarySearchTree1(root.Left)
                && root.Right == null ? true : root.Value < MinValue(root.Right) && IsBinarySearchTree1(root.Right);
        }

        public static bool IsBinarySearchTree(TreeNode root, int floor = int.MinValue, int cieling = int.MaxValue)
        {
            if (root == null)
            {
                return true;
            }
            return (root.Value >= floor 
                    &&  root.Value <= cieling
                    && IsBinarySearchTree(root.Left, floor, Math.Min(root.Value, cieling))
                    && IsBinarySearchTree(root.Right, Math.Max(root.Value, floor), cieling));
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

        public static TreeNode FirstCommonAncestor (TreeNode root, TreeNode n1, TreeNode n2)
        {
            if (root == null || n1 == null || n2 == null)
            {
                throw new NullReferenceException();
            }
            throw new NotImplementedException();
            return null;
        }

        public static bool ContainSubtreeFromRoot (TreeNode root, TreeNode subTreeRoot)
        {
            if (root == null && subTreeRoot != null)
            {
                return false;
            }
            else if (subTreeRoot == null)
            {
                return true;
            }
            else if (root.Value != subTreeRoot.Value)
            {
                return false;
            }
            else
            {
                return ContainSubtreeFromRoot(root.Left, subTreeRoot.Left) && ContainSubtreeFromRoot(root.Right, subTreeRoot.Right);
            }
        }

        #region Traverse In-Order;
        public static void TraverseInOrder(TreeNode root, Action<TreeNode > processNode)
        {
            if ( root == null)
            {
                return;
            }
            TraverseInOrder(root.Left, processNode);
            processNode(root);
            TraverseInOrder(root.Right, processNode);
        }


        /// <summary>
        /// TODO:
        /// Could be done simplier:
        /// iterativeInorder(node)
        ///s ← empty stack
            ///while (not s.isEmpty() or node ≠ null)
            ///     if (node ≠ null)
            ///      s.push(node)
            ///      node ← node.left
            ///    else
            ///      node ← s.pop()
            ///      visit(node)
            ///      node ← node.right
        /// </summary>
        /// <param name="root"></param>
        /// <param name="processNode"></param>
        public static void TraverseInOrderIterative(TreeNode root, Action<TreeNode> processNode)
        {
            if (root == null)
            {
                throw new NullReferenceException();
            }
            var traverseStack = new Stack<TreeNode>();
            traverseStack.Push(root);
            var current = root;

            while (current!= null)
            {
                while (current.Left != null)
                {
                    traverseStack.Push(current.Left);
                    current = current.Left;
                }

                if (traverseStack.Count > 0)
                {
                    current = traverseStack.Pop();
                }
                else
                {
                    break;
                }
                processNode(current);

                if (current.Right != null)
                {
                    traverseStack.Push(current.Right);
                    current = current.Right;
                }
            }
        }
        #endregion
    }
}
