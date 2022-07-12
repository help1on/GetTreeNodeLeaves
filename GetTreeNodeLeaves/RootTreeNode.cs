using System;
using System.Collections.Generic;
using System.Text;

namespace GetTreeNodeLeaves
{
    public class RootTreeNode
    {
        public int data;
        public int[] children;
        public RootTreeNode[] Children { get; set; }
    }
}
