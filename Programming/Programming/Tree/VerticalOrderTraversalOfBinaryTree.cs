/*
Vertical Order traversal of Binary Tree
Asked in:  
Amazon
Problem Setter: yashpal1995 Problem Tester: RAMBO_tejasv
Given a binary tree, return a 2-D array with vertical order traversal of it.
Go through the example and image for more details.

Example :
Given binary tree:

      6
    /   \
   3     7
  / \     \
 2   5     9
returns

[
    [2],
    [3],
    [6 5],
    [7],
    [9]
]

Note : If 2 Tree Nodes shares the same vertical level then the one with lesser depth will come first.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Tree
{
    public class VerticalOrderTraversalOfBinaryTree
    {
        public List<List<int>> VerticalOrderTraversal(TreeNode A)
        {
            if (A == null)
                return null;

            List<List<int>> result = new List<List<int>>();
            Queue<Tuple<TreeNode, int>> queue = new Queue<Tuple<TreeNode, int>>();
            IDictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int min = int.MaxValue;
            int max = int.MinValue;

            queue.Enqueue(Tuple.Create(A, 0));
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (!map.ContainsKey(node.Item2))
                    map.Add(node.Item2, new List<int>());

                map[node.Item2].Add(node.Item1.val);
                min = Math.Min(min, node.Item2);
                max = Math.Max(max, node.Item2);

                if (node.Item1.left != null)
                    queue.Enqueue(Tuple.Create(node.Item1.left, node.Item2 - 1));
                if (node.Item1.right != null)
                    queue.Enqueue(Tuple.Create(node.Item1.right, node.Item2 + 1));
            }
            for(int i = min; i <= max; i++)
            {
                result.Add(map[i]);
            }
            return result;
        }
        /*public static void Main(string[] args)
        {
            VerticalOrderTraversalOfBinaryTree m = new VerticalOrderTraversalOfBinaryTree();
            TreeNode A = new TreeNode(6);
            A.left = new TreeNode(3);
            A.right = new TreeNode(7);
            A.left.left = new TreeNode(2);
            A.left.right = new TreeNode(5);
            A.right.right = new TreeNode(9);
            var result = m.VerticalOrderTraversal(A);
        }*/
    }
}
