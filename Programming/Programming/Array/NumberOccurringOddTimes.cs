/*
 * Find the Number Occurring Odd Number of Times
Given an array of positive integers. All numbers occur even number of times except one number which occurs odd number of times. Find the number in O(n) time & constant space.
Examples :

Input : arr = {1, 2, 3, 2, 3, 1, 3}
Output : 3

Input : arr = {5, 7, 2, 7, 5, 2, 5}
Output : 5
*/

using System.Collections.Generic;

namespace Programming.Array
{
    public class NumberOccurringOddTimes
    {
        public int FindTheNumberOccurringOddTimes(int[] a)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!dictionary.ContainsKey(a[i]))
                    dictionary.Add(a[i], 1);
                else
                    dictionary[a[i]] = dictionary[a[i]] + 1;
            }
            foreach (var t in dictionary)
            {
                if (t.Value % 2 == 1)
                    return t.Key;
            }
            return -1;
        }
        public int FindTheNumberOccurringOddTimes1(int[] a)
        {
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result = result ^ a[i];
            }
            return result;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 2, 3, 1, 3 };
            NumberOccurringOddTimes obj = new NumberOccurringOddTimes();
            var result = obj.FindTheNumberOccurringOddTimes1(a);
        }*/
    }
}
