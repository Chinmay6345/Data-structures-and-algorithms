using System;
using Ttree_Traversals;
using System.Collections.Generic;

namespace Serialize_and_Deserialize_a_Binary_Tree
{
    public static class AppHelper
    {
        public static Int32 index=0;

        public static void Serialize(BinaryTree root,List<Int32>lst)
        {
            if(root.Equals(null))
            {
                lst.Add(-1);
                return;
            }
            lst.Add(root.key);
            Serialize(root.left, lst);
            Serialize(root.right, lst);
        }

        public static BinaryTree Deserialize(List<Int32>lst)
        {
            if (index == lst.Count)
                return null;

            Int32 val = lst[index];
            index++;

            if (val == -1)
                return null;

            BinaryTree root = new BinaryTree(val);
            root.left = Deserialize(lst);
            root.right = Deserialize(lst);

            return root;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
