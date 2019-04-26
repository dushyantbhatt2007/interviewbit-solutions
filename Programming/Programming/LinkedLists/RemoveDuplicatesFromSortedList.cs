/* 
 
 * * Remove Duplicates from Sorted List * *
 
Given a sorted linked list, delete all duplicates such that each element appear only once.

For example,
Given 1->1->2, return 1->2.
Given 1->1->2->3->3, return 1->2->3.

*/

namespace Programming.LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode RemoveDuplicates(ListNode A)
        {
            if (A == null)
                return A;
            ListNode curr = A;
            while (curr.next != null)
            {
                if (curr.next.val == curr.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }
            return A;
        }
        /*public static void Main(string[] args)
        {
            ListNode A = new ListNode(1);
            A.next = new ListNode(2);
            A.next.next = new ListNode(2);
            A.next.next.next = new ListNode(2);
            A.next.next.next.next = new ListNode(2);
            A.next.next.next.next.next = new ListNode(3);
            RemoveDuplicatesFromSortedList r = new RemoveDuplicatesFromSortedList();
            var result = r.RemoveDuplicates(A);
        }*/
    }
    
}
