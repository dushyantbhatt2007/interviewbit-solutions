/*
Binary Tree From Inorder And Postorder
Asked in:  
Amazon
Microsoft
Given inorder and postorder traversal of a tree, construct the binary tree.

 Note: You may assume that duplicates do not exist in the tree. 
Example :

Input : 
        Inorder : [2, 1, 3]
        Postorder : [2, 3, 1]

Return : 
            1
           / \
          2   3
*/
using System.Collections.Generic;

namespace Programming.Tree
{
    public class BinaryTreeFromInorderAndPostorder
    {
        public TreeNode BuidlTree(List<int> A,List<int> B)
        {
            if (A == null && B == null)
                return null;
            if (A == null || B == null)
                return null;
            if (A.Count == 0 || (A.Count != B.Count))
                return null;
            return BuildTreeHelper(A, B, 0, A.Count - 1, 0, B.Count - 1);
        }
        public TreeNode BuildTreeHelper(List<int> inorder, List<int> postorder, int inStart, int inEnd, int preStart, int preEnd)
        {
            if (preStart > preEnd)
                return null;
            TreeNode root = new TreeNode(postorder[preEnd]);
            if (preStart == preEnd)
                return root;
            int splitIndex = inStart;
            int count = 0;
            for(int i = inStart; i <= inEnd; i++)
            {
                count++;
                if(inorder[i]==postorder[preEnd])
                {
                    splitIndex = i;
                    break;
                }
            }
            int numberOfNodes = splitIndex - inStart;
            root.left = BuildTreeHelper(inorder, postorder,inStart, splitIndex - 1, preStart, preStart + numberOfNodes - 1);
            root.right = BuildTreeHelper(inorder, postorder, splitIndex + 1, inEnd, preStart + numberOfNodes, preEnd - 1);
            return root;
        }

        /*public static void Main(string[] args)
        {
            BinaryTreeFromInorderAndPostorder m = new BinaryTreeFromInorderAndPostorder();
            List<int> A = new List<int>();
            A.Add(2);
            A.Add(1);
            A.Add(3);
            List<int> B = new List<int>();
            B.Add(2);
            B.Add(3);
            B.Add(1);
            var result = m.BuidlTree(A,B);
        }*/
    }
}
