/*
 * Find duplicates in O(n) time and O(1) extra space | Set 1
Given an array of n elements which contains elements from 0 to n-1, with any of these numbers appearing any number of times. Find these repeating numbers in O(n) and using only constant memory space.
For example, let n be 7 and array be {1, 2, 3, 1, 3, 6, 6}, the answer should be 1, 3 and 6.
*/
using System;

namespace Programming.Array
{
    public class DuplicatesInArray
    {
        public void PrintRepeatingNumbers(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[Math.Abs(a[i])] >= 0)
                    a[Math.Abs(a[i])] = -a[Math.Abs(a[i])];
                else
                    Console.WriteLine(Math.Abs(a[i]));
            }
        }
        public void PrintRepeatingNumbers1(int[] a)
        {
            int n = a.Length;
            // First check all the values that are present in an array then go to that 
            // values as indexes and increment by the size of array 
            for (int i = 0; i < n; i++)
            {
                int index = a[i] % n;
                a[index] += n;
            }

            // Now check which value exists more than once by dividing with the size of array 
            for (int i = 0; i < n; i++)
            {
                if ((a[i] / n) > 1)
                    Console.Write(i + " ");
            }
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 1, 3, 6, 6 };
            DuplicatesInArray obj = new DuplicatesInArray();
            obj.PrintRepeatingNumbers1(a);
        }*/
    }
}
