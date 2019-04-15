using System.Collections.Generic;

namespace Programming.Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
    }
    public class InOrder
    {
        public List<int> InOrderTraversal(TreeNode A)
        {
            List<int> res = new List<int>();
            if (A == null)
                return res;
            TreeNode curr = A;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (curr != null || stack.Count > 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                res.Add(curr.val);
                curr = curr.right;
            }
            return res;
        }
        public static void Main(string[] args)
        {
            InOrder i = new InOrder();
            TreeNode A = new TreeNode(10);
            A.left = new TreeNode(6);
            A.right = new TreeNode(9);
            A.right.left = new TreeNode(8);
            A.left.left = new TreeNode(4);
            var result = i.InOrderTraversal(A);
        }
    }
}
