/*
Flatten Binary Tree to Linked List
Asked in:  
Adobe
Amazon
Microsoft
Given a binary tree, flatten it to a linked list in-place.

Example :
Given


         1
        / \
       2   5
      / \   \
     3   4   6
The flattened tree should look like:

   1
    \
     2
      \
       3
        \
         4
          \
           5
            \
             6
Note that the left child of all nodes should be NULL.
*/
using System.Collections.Generic;
using System.Linq;

namespace Programming.Tree
{
    public class FlattenBinaryTreeToLinkedList
    {
        TreeNode node;
        public TreeNode FlattenBinaryTree(TreeNode A)
        {
            TreeNode result = new TreeNode(A.val);
            node = result;
            result.right = node;
            if (A == null)
                return null;

            FlattenTree(A.left);
            FlattenTree(A.right);
            return result;
        }
        public void FlattenTree(TreeNode A)
        {
            if (A != null)
            {
                node.right = new TreeNode(A.val);
                node = node.right;
                FlattenTree(A.left);
                FlattenTree(A.right);
            }
        }
        public TreeNode Flatten(TreeNode A)
        {
            if (A == null)
                return null;
            LinkedList<TreeNode> stack = new LinkedList<TreeNode>();
            TreeNode result = new TreeNode(0);
            node = result;
            result.right = node;
            stack.AddFirst(A);
            while (stack.Count > 0)
            {
                TreeNode popped = stack.First();
                stack.RemoveFirst();
                node.right = new TreeNode(popped.val);
                node = node.right;

                if (popped.right != null)
                    stack.AddFirst(popped.right);
                if (popped.left != null)
                    stack.AddFirst(popped.left);
            }
            return result.right;
        }
        /*public static void Main(string[] args)
        {
            FlattenBinaryTreeToLinkedList m = new FlattenBinaryTreeToLinkedList();
            TreeNode A = new TreeNode(1);
            A.left = new TreeNode(2);
            A.right = new TreeNode(5);
            A.left.left = new TreeNode(3);
            A.left.right = new TreeNode(4);
            A.right.right = new TreeNode(6);
            //var result = m.FlattenBinaryTree(A);
            var result = m.Flatten(A);
        }*/
    }
}
