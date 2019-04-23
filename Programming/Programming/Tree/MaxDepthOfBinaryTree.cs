/*Given a binary tree, find its maximum depth.

The maximum depth of a binary tree is the number of nodes along the longest path from the root node down to the farthest leaf node.

 NOTE : The path has to end on a leaf node. 
Example :

         1
        /
       2
max depth = 2.*/

using System;
using System.Collections.Generic;

namespace Programming.Tree
{
    public class MaxDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode A)
        {
            int result = 0;
            if (A == null)
                return 0;
            Queue<Tuple<TreeNode,int>> queue = new Queue<Tuple<TreeNode, int>>();
            queue.Enqueue(new Tuple<TreeNode, int>(A,1));
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.Item1.left != null)
                    queue.Enqueue(new Tuple<TreeNode, int>(node.Item1.left,node.Item2+1));
                if (node.Item1.right != null)
                    queue.Enqueue(new Tuple<TreeNode, int>(node.Item1.right, node.Item2 + 1));

                result = Math.Max(result, node.Item2);
            }
            return result;
        }
        public static void Main(string[] args)
        {
            MaxDepthOfBinaryTree m = new MaxDepthOfBinaryTree();
            TreeNode A = new TreeNode(5);
            A.left = new TreeNode(3);
            A.right = new TreeNode(6);
            A.left.left = new TreeNode(1);
            var result = m.MaxDepth(A);
        }
    }
}
