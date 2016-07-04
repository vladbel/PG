using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.BT
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        #region Custom tree node properties
        public TreeNode InOrderNext { get; set; }
        public TreeNode InOrderPrevious { get; set; }
        #endregion
    }
}
