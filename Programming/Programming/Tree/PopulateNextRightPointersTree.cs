/*
 * 
Populate Next Right Pointers Tree
Asked in:  
Microsoft
Amazon
Given a binary tree

    struct TreeLinkNode {
      TreeLinkNode *left;
      TreeLinkNode *right;
      TreeLinkNode *next;
    }
Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

Initially, all next pointers are set to NULL.

 Note:
You may only use constant extra space.
Example :

Given the following binary tree,

         1
       /  \
      2    3
     / \  / \
    4  5  6  7
After calling your function, the tree should look like:

         1 -> NULL
       /  \
      2 -> 3 -> NULL
     / \  / \
    4->5->6->7 -> NULL
    */
using System.Collections.Generic;

namespace Programming.Tree
{
    public class TreeLinkNode
    {
        public int data;
        public TreeLinkNode left, right, nextRight;

        public TreeLinkNode(int item)
        {
            data = item;
            left = right = nextRight = null;
        }
    }

    public class PopulateNextRightPointersTree
    {
        public TreeLinkNode PopulateNextRight(TreeLinkNode A)
        {
            var result = A;
            while (A != null)
            {
                TreeLinkNode p = A;
                while (p != null)
                {
                    if (p.left != null)
                        p.left.nextRight = p.right;
                    if (p.right != null && p.nextRight != null)
                        p.right.nextRight = p.nextRight.left;
                    p = p.nextRight;
                }
                A = A.left;
            }
            return result;
        }

        public TreeLinkNode PopulateNextRight1(TreeLinkNode A)
        {
            TreeLinkNode result = A;
            if (A == null)
            {
                return A;
            }

            Queue<TreeLinkNode> queue = new Queue<TreeLinkNode>();
            queue.Enqueue(A);
            queue.Enqueue(null);

            while (queue.Peek() != null)
            {
                int size = queue.Count - 1;
                while (size-- > 0)
                {
                    TreeLinkNode node = queue.Dequeue();
                    node.nextRight = queue.Peek();
                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                queue.Dequeue();
                queue.Enqueue(null);
            }
            return result;
        }
        
        /*public static void Main(string[] args)
        {
            PopulateNextRightPointersTree obj = new PopulateNextRightPointersTree();
            TreeLinkNode A = new TreeLinkNode(1);
            A.left = new TreeLinkNode(2);
            A.right = new TreeLinkNode(3);
            A.left.left = new TreeLinkNode(4);
            A.left.right = new TreeLinkNode(5);
            A.right.left = new TreeLinkNode(6);
            A.right.right = new TreeLinkNode(7);
            var result = obj.PopulateNextRight(A);
        }*/
    }
}
