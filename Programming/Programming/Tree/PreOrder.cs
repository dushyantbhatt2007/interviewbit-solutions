using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Tree
{
    public class PreOrder
    {
        public List<int> PreOrderTraversal(TreeNode A)
        {
            List<int> res = new List<int>();
            var curr = A;
            if (curr == null)
                return res;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(curr);
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                res.Add(temp.val);
                if (temp.right != null)
                    stack.Push(temp.right);
                if (temp.left != null)
                    stack.Push(temp.left);
            }

            return res;
        }
        public static void Main(string[] args)
        {
            PreOrder p = new PreOrder();
            TreeNode A = new TreeNode(10);
            A.left = new TreeNode(6);
            A.right = new TreeNode(9);
            A.right.left = new TreeNode(8);
            A.left.left = new TreeNode(4);
            var result = p.PreOrderTraversal(A);
        }
    }
}
