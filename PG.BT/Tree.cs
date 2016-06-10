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
        public static int MaxDepth (Node root, int depth = 0)
        {
            if (root == null)
            {
                throw new NullReferenceException("Tree root can't be null");
            }
            return Math.Max(root.Left == null ? depth : MaxDepth(root.Left, depth + 1),
                            root.Right == null ? depth : MaxDepth(root.Right, depth + 1));
        }
    }
}
