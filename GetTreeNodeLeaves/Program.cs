using System;
using System.Collections.Generic;

namespace GetTreeNodeLeaves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = CreateTreeNode(0);
            root.left = CreateTreeNode(1);
            root.right = CreateTreeNode(2);
            root.left.left = CreateTreeNode(3);
            root.left.right = CreateTreeNode(4);
            root.right.middle = CreateTreeNode(5);
            root.left.left.left = CreateTreeNode(6);
            root.right.middle.left = CreateTreeNode(7);
            root.right.middle.middle = CreateTreeNode(8);
            root.right.middle.right = CreateTreeNode(9);
            root.right.middle.middle.middle = CreateTreeNode(10);
            root.right.middle.right.right = CreateTreeNode(11);

            GetTreeNodeLeaves(root);
        }
        public static void GetTreeNodeLeaves(TreeNode root)
        {
            if (root == null)
            {
                Console.WriteLine("your TreeNode is empty");
            }
            if (root.left == null && root.right == null && root.middle == null)
            {
                Console.WriteLine(root.data + " ");
            }
            if (root.left != null)
            {
                GetTreeNodeLeaves(root.left);
            }
            if (root.middle != null)
            {
                GetTreeNodeLeaves(root.middle);
            }
            if (root.right != null)
            {
                GetTreeNodeLeaves(root.right);
            }
        }

        //added code
        public static void FindChildren(RootTreeNode root)
        {
            List<RootTreeNode> storage = new List<RootTreeNode>();
            if (root.Children.Length == 0)
            {
                storage.Add(root);
            }
            else
            {
                foreach (var item in root.Children)
                {
                    FindChildren(item);
                }
            }
            foreach (var item in storage)
            {
                Console.WriteLine(item + "");
            }
        }

        static TreeNode CreateTreeNode(int data)
        {
            TreeNode t = new TreeNode
            {
                data = data,
                left = null,
                middle = null,
                right = null
            };
            return t;
        }
    }
}
