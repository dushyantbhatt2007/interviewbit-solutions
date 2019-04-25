/*
Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.

An example is the root-to-leaf path 1->2->3 which represents the number 123.

Find the total sum of all root-to-leaf numbers % 1003.

Example :

    1
   / \
  2   3
The root-to-leaf path 1->2 represents the number 12.
The root-to-leaf path 1->3 represents the number 13.

Return the sum = (12 + 13) % 1003 = 25 % 1003 = 25.*/


namespace Programming.Tree
{
    public class SumRootToLeafNumbers
    {
        private int sum = 0;
        public int sumNumbers(TreeNode A)
        {
            DFS(A, 0);
            return sum % 1003;
        }
        public void DFS(TreeNode A,int val)
        {
            if (A == null)
                return;
            if (val > 1003)
                val = val % 1003;
            var tmp = val * 10 + A.val;
            if (A.left == null && A.right == null)
                sum += tmp;
            DFS(A.left,tmp);
            DFS(A.right, tmp);
        }
        public static void Main(string[] args)
        {
            SumRootToLeafNumbers m = new SumRootToLeafNumbers();
            TreeNode A = new TreeNode(1);
            A.left = new TreeNode(2);
            A.right = new TreeNode(3);
            var result = m.sumNumbers(A);
        }
    }
}
