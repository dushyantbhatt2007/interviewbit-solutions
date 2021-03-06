﻿/*Min Depth of Binary Tree
Asked in:  
Facebook
Amazon
Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

 NOTE : The path has to end on a leaf node.
Example :

         1
        /
       2
min depth = 2.*/
using System;
using System.Collections.Generic;

namespace Programming.Tree
{
    public class MinDepthOfBinaryTree
    {
        public int MinDepth(TreeNode A)
        {
            return Depth(A);
        }
        public int Depth(TreeNode A)
        {
            if (A == null)
                return 0;

            int left = Depth(A.left);
            int right = Depth(A.right);
            int min = (left == 0 || right == 0) ? left + right + 1 : Math.Min(left, right) + 1;
            return min;
        }

        public int MinDepth1(TreeNode A)
        {
            int result = int.MaxValue;
            if (A == null)
                return 0;
            Queue<Tuple<TreeNode, int>> queue = new Queue<Tuple<TreeNode, int>>();
            queue.Enqueue(new Tuple<TreeNode, int>(A, 1));
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.Item1.left != null)
                    queue.Enqueue(new Tuple<TreeNode, int>(node.Item1.left, node.Item2 + 1));
                if (node.Item1.right != null)
                    queue.Enqueue(new Tuple<TreeNode, int>(node.Item1.right, node.Item2 + 1));

                if (node.Item1.left == null && node.Item1.right == null)
                    result = Math.Min(result, node.Item2);
            }
            return result;
        }
        /*public static void Main(string[] args)
        {
            MinDepthOfBinaryTree m = new MinDepthOfBinaryTree();
            TreeNode A = new TreeNode(5);
            A.left = new TreeNode(3);
            A.right = new TreeNode(6);
            A.left.left = new TreeNode(1);
            var result = m.MinDepth(A);
        }*/
    }
}
