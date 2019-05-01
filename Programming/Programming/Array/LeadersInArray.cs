/*

Leaders in an array
Write a program to print all the LEADERS in the array.An element is leader if it is greater than all the elements to its right side.And the rightmost element is always a leader.For example int the array { 16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2.
Let the input array be arr[] and size of the array be size.

 */
using System.Collections.Generic;

namespace Programming.Array
{
    public class LeadersInArray
    {
        public List<int> LeadersInArr(int[] a)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] <= a[j])
                        break;
                }
                if (j == a.Length)
                    result.Add(a[i]);
            }
            return result;
        }
        public List<int> LeadersInArr1(int[] a)
        {
            List<int> result = new List<int>();
            result.Add(a[a.Length - 1]);
            int max_right = a[a.Length - 1];
            for (int i = a.Length - 2; i >= 0; i--)
            {
                if (max_right < a[i])
                {
                    result.Add(a[i]);
                    max_right = a[i];
                }
            }
            return result;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 16, 17, 4, 3, 5, 2 };
            LeadersInArray obj = new LeadersInArray();
            var result = obj.LeadersInArr1(a);
        }*/
    }
}
