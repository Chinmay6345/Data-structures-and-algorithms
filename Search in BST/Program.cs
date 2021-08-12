using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_BST
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static class AppHelper
    {
        public static bool Search(TreeNode root,int x)
        {
            if (root == null) return false;
            if (root.val == x) return true;
            if (root.val > x)
                return Search(root.left, x);
            else
                return Search(root.right, x);
        }

        public static bool IterativeSearch(TreeNode root, int x)
        {
            if (root == null) return false;
            while(root!=null)
            {
                if (root.val == x)
                {
                    return true;
                }
                else if (root.val > x)
                    root = root.left;
                else
                    root = root.right;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
