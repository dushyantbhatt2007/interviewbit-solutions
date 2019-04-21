/*Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

Example :

Given the below binary tree and sum = 22,

              5
             / \
            4   8
           /   / \
          11  13  4
         /  \      \
        7    2      1
return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.

Return 0 / 1 ( 0 for false, 1 for true ) for this problem*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Tree
{
    public class PathSum
    {
        public int hasPathSum(TreeNode A, int B)
        {
            if (A == null)
                return 0;

            return FindSumLogic(A, A.val, B);
        }
        public int FindSumLogic(TreeNode A, int val, int sum)
        {
            if (A == null)
                return 0;
            if (val == sum)
            {
                if (A.left == null && A.right == null)
                    return 1;
            }
            if (A.left != null)
            {
                if (FindSumLogic(A.left, val + A.left.val, sum) == 1)
                    return 1;
            }
            if (A.right != null)
            {
                if (FindSumLogic(A.right, val + A.right.val, sum) == 1)
                    return 1;
            }
            return 0;
        }
        public static void Main(string[] args)
        {
            PathSum p = new PathSum();
            TreeNode A = new TreeNode(5);
            A.left = new TreeNode(4);
            A.right = new TreeNode(8);
            A.right.left = new TreeNode(13);
            A.right.right = new TreeNode(4);
            A.right.right.right = new TreeNode(1);
            A.left.left = new TreeNode(11);
            A.left.left.left = new TreeNode(7);
            A.left.left.right = new TreeNode(2);
            var result = p.hasPathSum(A, 22);
        }
    }
}
