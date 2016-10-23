using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.BT.Tests
{
    internal class TestTreeFactory
    {
        /// <summary>
        /// Balanced search tree
        ///                      4
        ///                   /     \
        ///                  2       6
        ///                 / \     / \
        ///                1   3   5   7
        /// </summary>
        static public TreeNode BST_1_7
        {
            get
            {
                return new TreeNode()
                {
                    Value = 4,
                    Left = new TreeNode()
                    {
                        Value = 2,
                        Left = new TreeNode()
                        {
                            Value = 1
                        },
                        Right = new TreeNode()
                        {
                            Value = 3
                        }
                    },
                    Right = new TreeNode()
                    {
                        Value = 6,
                        Left = new TreeNode()
                        {
                            Value = 5
                        },
                        Right = new TreeNode()
                        {
                            Value = 7
                        }
                    }
                };
            }
        }

        /// <summary>
        /// Balanced search tree with +1 branch
        ///                      4
        ///                   /     \
        ///                  2       6
        ///                 / \     / \
        ///                1   3   5   7
        ///                             \
        ///                              8
        /// </summary>
        static public TreeNode BST_1_8
        {
            get
            {
                return new TreeNode()
                {
                    Value = 4,
                    Left = new TreeNode()
                    {
                        Value = 2,
                        Left = new TreeNode()
                        {
                            Value = 1
                        },
                        Right = new TreeNode()
                        {
                            Value = 3
                        }
                    },
                    Right = new TreeNode()
                    {
                        Value = 6,
                        Left = new TreeNode()
                        {
                            Value = 5
                        },
                        Right = new TreeNode()
                        {
                            Value = 7,
                            Right = new TreeNode()
                            {
                                Value = 8
                            }
                        }
                    }
                };
            }
        }


        /// <summary>
        /// only left branch
        ///                    4
        ///                   / \
        ///                  2...null
        ///                 / \
        ///                1   3
        /// /// </summary>
        static public TreeNode BST_1_4_NotBalanced
        {
            get
            {
                return new TreeNode()
                {
                    Value = 4,
                    Left = new TreeNode()
                    {
                        Value = 2,
                        Left = new TreeNode()
                        {
                            Value = 1
                        },
                        Right = new TreeNode()
                        {
                            Value = 3
                        }
                    },
                    Right = null
                };
            }
        }

        /// <summary>
        /// only right branch
        ///                      4
        ///                   /     \
        ///                 null       6
        ///                           / \
        ///                          5   7
        /// </summary>
        static public TreeNode BST_4_7_NotBalanced
        {
            get
            {
                return new TreeNode()
                {
                    Value = 4,
                    Left = null,
                    Right = new TreeNode()
                    {
                        Value = 6,
                        Left = new TreeNode()
                        {
                            Value = 5
                        },
                        Right = new TreeNode()
                        {
                            Value = 7
                        }
                    }
                };
            }
        }
    }
}
