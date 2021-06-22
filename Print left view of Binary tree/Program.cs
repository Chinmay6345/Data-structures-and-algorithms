using System;
using Ttree_Traversals;


namespace Print_left_view_of_Binary_tree
{
    public static class AppHelper
    {
        static int maxlevel = 0;
        public static void LeftView(BinaryTree root,int level)
        {
            if (root == null)
                return;
            if(maxlevel <level)
            {
                Console.WriteLine(root.key);
                maxlevel = level;
            }
            LeftView(root.left,level + 1);
            LeftView(root.left, level + 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
