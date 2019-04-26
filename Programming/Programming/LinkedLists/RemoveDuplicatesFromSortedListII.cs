/*Remove Duplicates from Sorted List II
Asked in:  
Microsoft
VMWare
Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.

For example,
Given 1->2->3->3->4->4->5, return 1->2->5.
Given 1->1->1->2->3, return 2->3.*/

namespace Programming.LinkedLists
{
    public class RemoveDuplicatesFromSortedListII
    {
        public ListNode DeleteDuplicates(ListNode A)
        {
            if (A == null || A.next == null)
                return A;
            ListNode dummyNode = new ListNode(int.MinValue);
            dummyNode.next = A;
            ListNode curr = A;
            ListNode prev = dummyNode;
            while(curr!=null && curr.next != null)
            {
                ListNode next = curr.next;
                if(curr.val==next.val)
                {
                    while(curr.next!=null && curr.val == next.val)
                    {
                        curr = curr.next;
                        next = next.next;   
                    }
                    prev.next = next;
                    curr = next;
                }
                else{
                    prev = prev.next;
                    curr = curr.next;
                }
            }
            return dummyNode.next;
        }
        /*public static void Main(string[] args)
        {
            ListNode A = new ListNode(1);
            A.next = new ListNode(2);
            A.next.next = new ListNode(2);
            A.next.next.next = new ListNode(2);
            A.next.next.next.next = new ListNode(2);
            A.next.next.next.next.next = new ListNode(3);
            RemoveDuplicatesFromSortedListII r = new RemoveDuplicatesFromSortedListII();
            var result = r.DeleteDuplicates(A);
        }*/
    }
}
