using System;
using System.Collections.Generic;
using Count_nodes_in_a_complete_Binary_Tree;


namespace Lowest_Common_Ancestor_of_a_Binary_Search_Tree
{
    public static class AppHelper
    {
        public static bool FindPath(TreeNode root,List<TreeNode>p,int n)
        {
            if (root == null)
                return false;
            p.Add(root);
            if (root.val == n)
                return true;
            if (FindPath(root.left, p, n) || FindPath(root.right, p, n))
                return true;
            p.RemoveAt(p.Count - 1);
            return false;
        }
        //O(n)
        public static Int32 LCA(TreeNode root,int n1,int n2)
        {
            List<TreeNode> lst1 = new List<TreeNode>();
            List<TreeNode> lst2 = new List<TreeNode>();

            if (FindPath(root.left, lst1, n1) == false || FindPath(root.right, lst2, n2) == false)
                return -1;
            for(int i=0;i<lst1.Count && i<lst2.Count;i++)
            {
                if(lst1[i+1].val==lst2[i+1].val)
                {
                    return lst1[i + 1].val;
                }
            }
            return -1;
        }
    }


    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val == p.val || root.val == q.val)
                return root;
            TreeNode lca1 = LowestCommonAncestor(root.left, p, q);
            TreeNode lca2 = LowestCommonAncestor(root.right, p, q);
            if (lca1 != null && lca2 != null)
                return root;
            if (lca1 != null)
                return lca1;
            if (lca2 != null)
                return lca2;
            return null;
        }
    }
}
