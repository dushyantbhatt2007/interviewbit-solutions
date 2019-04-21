/*Given a binary tree, return the postorder traversal of its nodes’ values.

Example :

Given binary tree

   1
    \
     2
    /
   3
return [3,2,1].

Using recursion is not allowed.*/
using System.Collections.Generic;

namespace Programming.Tree
{
    public class PostOrder
    {
        public List<int> PostOrderTraversal(TreeNode A)
        {
            List<int> res = new List<int>();
            if (A == null)
                return res;

            TreeNode curr = A;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while(true)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    stack.Push(curr);
                    curr = curr.left;
                }
                if (stack.Count == 0)
                    return res;
                curr = stack.Pop();

                if (stack.Count != 0 && stack.Peek() == curr)
                    curr = curr.right;
                else
                {
                    res.Add(curr.val);
                    curr = null;
                }
            }
        }
        /*public static void Main(string[] args)
        {
            PostOrder p = new PostOrder();
            TreeNode A = new TreeNode(10);
            A.left = new TreeNode(6);
            A.right = new TreeNode(9);
            A.right.left = new TreeNode(8);
            A.left.left = new TreeNode(4);
            var result = p.PostOrderTraversal(A);
        }*/
    }
}
