/*Given a binary tree and a sum, find all root-to-leaf paths where each path’s sum equals the given sum.

For example:
Given the below binary tree and sum = 22,

              5
             / \
            4   8
           /   / \
          11  13  4
         /  \    / \
        7    2  5   1
return

[
   [5,4,11,2],
   [5,8,4,5]
]*/
using System.Collections.Generic;

namespace Programming.Tree
{
    public class RootToLeafPathWithSum
    {
        List<List<int>> result;
        List<int> temp;
        public List<List<int>> PathSum(TreeNode A, int B)
        {
            temp = new List<int>();
            result = new List<List<int>>();

            if (A == null)
                return result;
            PathSum1(A, B);
            return result;
        }
        public void PathSum1(TreeNode A, int sum)
        {
            if (A == null)
                return;
            var currentVal = A.val;
            temp.Add(currentVal);
            if (A.left == null && A.right == null)
            {
                if (sum - currentVal == 0)
                    result.Add(new List<int>(temp));
            }
            PathSum1(A.left, sum - A.val);
            PathSum1(A.right, sum - A.val);
            temp.RemoveAt(temp.Count - 1);
        }
        public static void Main(string[] args)
        {
            RootToLeafPathWithSum r = new RootToLeafPathWithSum();
            TreeNode A = new TreeNode(5);
            A.left = new TreeNode(4);
            A.right = new TreeNode(8);
            A.right.left = new TreeNode(13);
            A.right.right = new TreeNode(4);
            A.right.right.right = new TreeNode(1);
            A.right.right.left = new TreeNode(5);
            A.left.left = new TreeNode(11);
            A.left.left.left = new TreeNode(7);
            A.left.left.right = new TreeNode(2);
            var result = r.PathSum(A, 22);
        }
    }
}
