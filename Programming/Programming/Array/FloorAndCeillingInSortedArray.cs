/*
Ceiling in a sorted array
Given a sorted array and a value x, the ceiling of x is the smallest element in array greater than or equal to x, and the floor is the greatest element smaller than or equal to x. Assume than the array is sorted in non-decreasing order. Write efficient functions to find floor and ceiling of x.

Examples :

For example, let the input array be {1, 2, 8, 10, 10, 12, 19}
For x = 0:    floor doesn't exist in array,  ceil  = 1
For x = 1:    floor  = 1,  ceil  = 1
For x = 5:    floor  = 2,  ceil  = 8
For x = 20:   floor  = 19,  ceil doesn't exist in array
In below methods, we have implemented only ceiling search functions. Floor search can be implemented in the same way.
*/
using System;

namespace Programming.Array
{
    public class FloorAndCeillingInSortedArray
    {

        public Tuple<int, int> FindFloorAndCeilingValue(int[] a, int floor, int ceil)
        {
            int f = -1, c = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (floor >= a[i])
                    f = Math.Max(a[i], f);
                if (ceil <= a[i])
                    c = Math.Min(a[i], c);
            }
            return new Tuple<int, int>(f, c);
        }
        public int CeilSearch(int[] a, int low, int high, int x)
        {
            int mid;
            if (x <= a[low])
                return a[low];
            if (x > a[high])
                return -1;
            mid = (low + high) / 2;
            if (a[mid] == x)
                return a[mid];
            else if (a[mid] < x)
            {
                if (mid + 1 <= high && x <= a[mid + 1])
                    return a[mid + 1];
                else
                    return CeilSearch(a, mid + 1, high, x);
            }
            else
            {
                if (mid - 1 >= low && x > a[mid - 1])
                    return a[mid];
                else
                    return CeilSearch(a, low, mid - 1, x);
            }
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 8, 10, 10, 12, 19 };
            FloorAndCeillingInSortedArray obj = new FloorAndCeillingInSortedArray();
            var result = obj.FindFloorAndCeilingValue(a, 5, 5);
            var result2 = obj.CeilSearch(a, 0, a.Length - 1, 5);
        }*/
    }
}
