/*
Sorted Array To Balanced BST
Asked in:  
VMWare
Amazon
Given an array where elements are sorted in ascending order, convert it to a height balanced BST.

 Balanced tree : a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1. 
Example :


Given A : [1, 2, 3]
A height balanced BST  : 

      2
    /   \
   1     3
*/
using System.Collections.Generic;

namespace Programming.Tree
{
    public class SortedArrayToBalancedBST
    {
        public TreeNode SortedArrayToBBST(List<int> A)
        {
            //TreeNode result = new TreeNode(0);
            var result = ConstructBST(A, 0, A.Count - 1);
            return result;
        }
        public TreeNode ConstructBST(List<int> A, int start, int end)
        {
            if (start > end)
                return null;
            int mid = (start + end) / 2;
            TreeNode root = new TreeNode(A[mid]);
            root.left = ConstructBST(A, 0, mid - 1);
            root.right = ConstructBST(A, mid + 1, end);
            return root;
        }
        /*public static void Main(string[] args)
        {
            SortedArrayToBalancedBST m = new SortedArrayToBalancedBST();
            List<int> A = new List<int>();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            var result = m.SortedArrayToBBST(A);
        }*/
    }
}
