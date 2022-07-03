using System;

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
        static void GetTreeNodeLeaves(TreeNode root)
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
            if(root.middle != null)
            {
                GetTreeNodeLeaves(root.middle);
            }
            if (root.right != null)
            {
                GetTreeNodeLeaves(root.right);
            }
        }

        static TreeNode CreateTreeNode(int data)
        {
            TreeNode t = new TreeNode();
            t.data = data;
            t.left = null;
            t.middle = null;
            t.right = null;
            return t;
        }
    }
}
