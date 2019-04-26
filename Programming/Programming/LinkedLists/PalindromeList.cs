/*
Palindrome List
Asked in:  
Amazon
Microsoft
Given a singly linked list, determine if its a palindrome. Return 1 or 0 denoting if its a palindrome or not, respectively.

Notes:

Expected solution is linear in time and constant in space.
For example,

List 1-->2-->1 is a palindrome.
List 1-->2-->3 is not a palindrome.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.LinkedLists
{

    public class PalindromeList
    {
        public int isPalindrome(ListNode A)
        {
            if (A == null || A.next == null)
                return 1;
            int count = 0;
            ListNode t = A;
            while(t!=null)
            {
                t = t.next;
                count++;
            }
            int mid = count / 2;
            ListNode previousNode = null;
            ListNode currentNode = A;
            ListNode first = A;
            for(int i = 0; i < mid; i++)
            {
                ListNode tmp = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = tmp;
            }
            first = previousNode;
            if (count % 2 == 1)
                currentNode = currentNode.next;
            for(int i = 0; i < mid; i++)
            {
                if (first.val != currentNode.val) return 0;

                first = first.next;
                currentNode = currentNode.next;
            }
            return 1;
        }
        /*public static void Main(string[] args)
        {
            ListNode A = new ListNode(1);
            A.next = new ListNode(2);
            A.next.next = new ListNode(2);
            A.next.next.next = new ListNode(1);
            PalindromeList obj = new PalindromeList();
            var result = obj.isPalindrome(A);
        }*/
    }
}
