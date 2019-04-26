/*Rotate List
Asked in:  
Amazon
Given a list, rotate the list to the right by k places, where k is non-negative.

For example:

Given 1->2->3->4->5->NULL and k = 2,
return 4->5->1->2->3->NULL.*/

namespace Programming.LinkedLists
{
    public class RotateList
    {
        public int getLength(ListNode A)
        {
            int count = 0;
            while (A != null)
            {
                A = A.next;
                count++;
            }
            return count;
        }

        public ListNode RotateRight(ListNode A,int B)
        {
            int len = getLength(A);
            int stop = B % len;
            if (stop == 0) return A;
            stop = len - stop;
            A = Rotate(A, stop);
            return A;
        }
        public ListNode Rotate(ListNode A,int stop)
        {
            ListNode head = null;
            ListNode curr = A;
            while (stop != 1)
            {
                curr = curr.next;
                stop--;
            }
            head = curr.next;
            curr.next = null;
            ListNode temp = head;
            while (temp.next != null)
                temp = temp.next;
            temp.next = A;
            return head;
        }
        /*public static void Main(string[] args)
        {
            ListNode A = new ListNode(1);
            A.next = new ListNode(2);
            A.next.next = new ListNode(3);
            A.next.next.next = new ListNode(4);
            A.next.next.next.next = new ListNode(5);
            RotateList obj = new RotateList();
            var result = obj.RotateRight(A, 2);
        }*/
    }
}
