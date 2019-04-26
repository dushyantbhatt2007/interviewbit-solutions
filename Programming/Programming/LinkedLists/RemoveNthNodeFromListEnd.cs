/*Remove Nth Node from List End
Asked in:  
HCL
Amazon
Given a linked list, remove the nth node from the end of list and return its head.

For example,
Given linked list: 1->2->3->4->5, and n = 2.
After removing the second node from the end, the linked list becomes 1->2->3->5.

 Note:
If n is greater than the size of the list, remove the first node of the list.
Try doing it using constant additional space.*/

namespace Programming.LinkedLists
{
    public class RemoveNthNodeFromListEnd
    {
        public int getLength(ListNode A)
        {
            int count=0;
            while (A != null)
            {
                A = A.next;
                count++;
            }
            return count;
        }
        public ListNode RemoveNthFromEnd(ListNode A,int B)
        {
            int len = getLength(A);
            int stop = len - B;
            if(stop<=0)
            {
                ListNode newHead = A.next;
                A = null;
                return newHead;
            }
            int count = 1;
            ListNode curr = A;
            while (count != stop)
            {
                curr = curr.next;
                count++;
            }
            curr.next = curr.next.next;
            return A;
        }
        /*public static void Main(string[] args)
        {
            ListNode A = new ListNode(1);
            A.next = new ListNode(2);
            A.next.next = new ListNode(3);
            A.next.next.next = new ListNode(4);
            A.next.next.next.next = new ListNode(5);
            RemoveNthNodeFromListEnd obj = new RemoveNthNodeFromListEnd();
            var result = obj.RemoveNthFromEnd(A,7);
        }*/
    }
}
