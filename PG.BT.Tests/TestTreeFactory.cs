using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.BT.Tests
{
    internal class TestTreeFactory
    {
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
