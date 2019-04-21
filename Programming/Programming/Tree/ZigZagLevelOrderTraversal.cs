/*Given a binary tree, return the zigzag level order traversal of its nodes’ values. (ie, from left to right, then right to left for the next level and alternate between).

Example : 
Given binary tree

    3
   / \
  9  20
    /  \
   15   7
return

[
         [3],
         [20, 9],
         [15, 7]
]*/
using System.Collections.Generic;

namespace Programming.Tree
{
    public class ZigZagLevelOrderTraversal
    {
        public List<List<int>> LevelOrderTraversal(TreeNode A)
        {
            List<List<int>> res = new List<List<int>>();
            if (A == null)
                return res;

            Stack<TreeNode> row = new Stack<TreeNode>();
            row.Push(A);
            bool ltr = true;
            while (row.Count > 0)
            {
                Stack<TreeNode> newrow = new Stack<TreeNode>();
                List<int> rowValues = new List<int>();
                while (row.Count > 0)
                {
                    var node = row.Pop();
                    if (ltr)
                    {
                        if (node.left != null) { newrow.Push(node.left); }
                        if (node.right != null) { newrow.Push(node.right); }
                    }
                    else
                    {
                        if (node.right != null) { newrow.Push(node.right); }
                        if (node.left != null) { newrow.Push(node.left); }
                    }
                    rowValues.Add(node.val);
                }
                row = newrow;
                res.Add(rowValues);
                ltr = !ltr;
            }
            return res;
        }
        /*public static void Main(string[] args)
        {
            ZigZagLevelOrderTraversal i = new ZigZagLevelOrderTraversal();
            TreeNode A = new TreeNode(3);
            A.left = new TreeNode(9);
            A.right = new TreeNode(20);
            A.right.left = new TreeNode(15);
            A.right.right = new TreeNode(7);
            var result = i.LevelOrderTraversal(A);
        }*/
    }
}
