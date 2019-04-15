/*
 * iven a binary tree, return the level order traversal of its nodes’ values. (ie, from left to right, level by level).
 * 
 Example :
 Given binary tree
 
 3
 / \
 9  20
 /  \
 15   7
 return its level order traversal as:
 
 [
 [3],
 [9,20],
 [15,7]
 ]
 Also think about a version of the question where you are asked to do a level order traversal of the tree when depth of the tree is much greater than number of nodes on a level.
 */

using System.Collections.Generic;
//Definition for binary tree
class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) {this.val = x; this.left = this.right = null;}
}

class Solution
{
   
    public List<List<int>> levelOrder(TreeNode A)
    {
        List<List<int>> result = new List<List<int>>();
        
        if (A == null)
            return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(A);
        
        while (queue.Count > 0)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            List<int> temp = new List<int>();
            while (queue.Count>0)
            {
                var node = queue.Dequeue();
                
                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
                temp.Add(node.val);
            }
            queue = q;
            result.Add(temp);
        }
        return result;
    }
   /* public static void Main(string[] args)
    {
        int V = 5; // Number of vertices in graph  

        Solution s = new Solution();
        TreeNode t = new TreeNode(5);
        TreeNode t1 = new TreeNode(4);
        TreeNode t2 = new TreeNode(6);
        TreeNode t4 = new TreeNode(2);
        TreeNode t5 = new TreeNode(7);
        t.left = t1;
        t.right = t2;
        t.left.left = t4;
        t.right.right = t5;

        s.levelOrder(t);
        
    }*/
}
