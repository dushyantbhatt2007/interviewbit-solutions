/*List Cycle
Asked in:  
Amazon
Microsoft
NetApp
Given a linked list, return the node where the cycle begins. If there is no cycle, return null.

Try solving it using constant additional space.

Example :

Input : 

                  ______
                 |     |
                 \/    |
        1 -> 2 -> 3 -> 4

Return the node corresponding to node 3. */

namespace Programming.LinkedLists
{
    public class ListCycle
    {
        public ListNode DetectCycle(ListNode A)
        {
            ListNode fast = A;
            ListNode slow = A;
            bool hasCycle = false;
            while(fast!=null && fast.next!=null && slow != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    hasCycle = true;
                    break;
                }
            }
            if (!hasCycle) return null;
            else
            {
                fast = A;
                while (fast != slow)
                {
                    fast = fast.next;
                    slow = slow.next;
                }
                return fast;
            }
        }
        /*public static void Main(string[] args)
        {
            ListNode A = new ListNode(1);
            A.next = new ListNode(2);
            A.next.next = new ListNode(3);
            A.next.next.next = new ListNode(4);
            A.next.next.next.next = A.next.next;
            ListCycle obj = new ListCycle();
            var result = obj.DetectCycle(A);
        }*/
    }
}
