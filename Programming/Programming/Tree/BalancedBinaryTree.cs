/*
 * Balanced Binary Tree
Asked in:  
Amazon
Given a binary tree, determine if it is height-balanced.

 Height-balanced binary tree : is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1. 
Return 0 / 1 ( 0 for false, 1 for true ) for this problem

Example :

Input : 
          1
         / \
        2   3

Return : True or 1 

Input 2 : 
         3
        /
       2
      /
     1

Return : False or 0 
         Because for the root node, left subtree has depth 2 and right subtree has depth 0. 
         Difference = 2 > 1. 
         */
using System;

namespace Programming.Tree
{
    public class BalancedBinaryTree
    {
        public bool isBalanced(TreeNode root)
        {
            /* If tree is empty then return true */
            if (root == null)
                return true;

            /* Get the height of left and right sub trees */
            int lh = height(root.left);
            int rh = height(root.right);

            if (Math.Abs(lh - rh) <= 1 && isBalanced(root.left) && isBalanced(root.right))
                return true;

            return false;
        }
        public int height(TreeNode node)
        {
            /* base case tree is empty */
            if (node == null)
                return 0;

            /* If tree is not empty then height = 1 + max of left height and right heights */
            return 1 + Math.Max(height(node.left), height(node.right));
        }
        public bool isBalanced1(TreeNode A)
        {
            return BalancedDepth(A) >= 0 ? true : false;
        }

        private int BalancedDepth(TreeNode node)
        {
            if (node == null) return 0;
            var left = BalancedDepth(node.left);
            if (left < 0) return left;
            var right = BalancedDepth(node.right);
            if (right < 0) return right;
            if (Math.Abs(left - right) > 1) return -1;
            return Math.Max(left, right) + 1;
        }
        /*public static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            //tree.left.left = new TreeNode(4);
            //tree.left.right = new TreeNode(5);
            tree.right.right = new TreeNode(6);
            tree.right.right.right = new TreeNode(7);
            //tree.left.left.left = new TreeNode(7);
            BalancedBinaryTree obj = new BalancedBinaryTree();
            if (obj.isBalanced1(tree))
                Console.WriteLine("Tree is balanced");
            else
                Console.WriteLine("Tree is not balanced");
        }*/
    }
}
