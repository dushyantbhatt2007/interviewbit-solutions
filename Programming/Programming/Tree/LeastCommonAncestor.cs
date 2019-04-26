/*
Find the lowest common ancestor in an unordered binary tree given two values in the tree.

 Lowest common ancestor : the lowest common ancestor (LCA) of two nodes v and w in a tree or directed acyclic graph (DAG) is the lowest (i.e. deepest) node that has both v and w as descendants. 
Example :


        _______3______
       /              \
    ___5__          ___1__
   /      \        /      \
   6      _2_     0        8
         /   \
         7    4
For the above tree, the LCA of nodes 5 and 1 is 3.

 LCA = Lowest common ancestor 
Please note that LCA for nodes 5 and 4 is 5.

You are given 2 values. Find the lowest common ancestor of the two nodes represented by val1 and val2
No guarantee that val1 and val2 exist in the tree. If one value doesn’t exist in the tree then return -1.
There are no duplicate values.
You can use extra memory, helper functions, and can modify the node struct but, you can’t add a parent pointer.*/

using System;
using System.Collections.Generic;

namespace Programming.Tree
{
    public class LeastCommonAncestor
    {
        public int Lca(TreeNode A, int B, int C)
        {
            if (A == null)
                return -1;

            List<TreeNode> bPath = new List<TreeNode>();
            List<TreeNode> cPath = new List<TreeNode>();

            if (!getPath(A, B, bPath) || !getPath(A, C, cPath))
                return -1;

            int len = Math.Min(bPath.Count, cPath.Count);
            for (int i = len; i > 0; i--)
            {
                if (bPath[bPath.Count - i] == cPath[cPath.Count - i])
                    return bPath[bPath.Count - i].val;
            }
            return -1;
        }
        public bool getPath(TreeNode n, int a, List<TreeNode> currentPath)
        {
            if (n == null)
                return false;

            if (n.val == a || getPath(n.left, a, currentPath) || getPath(n.right, a, currentPath))
            {
                currentPath.Add(n);
                return true;
            }
            return false;
        }
        /*public static void Main(string[] args)
        {
            LeastCommonAncestor m = new LeastCommonAncestor();
            TreeNode A = new TreeNode(3);
            A.left = new TreeNode(5);
            A.right = new TreeNode(1);
            A.left.left = new TreeNode(6);
            A.left.right = new TreeNode(2);
            A.right.left = new TreeNode(0);
            A.right.right = new TreeNode(8);
            var result = m.Lca(A, 6, 2);
        }*/
    }
}