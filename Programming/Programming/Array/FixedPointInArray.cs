/*
 * Find a Fixed Point (Value equal to index) in a given array
Given an array of n distinct integers sorted in ascending order, write a function that returns a Fixed Point in the array, if there is any Fixed Point present in array, else returns -1. Fixed Point in an array is an index i such that arr[i] is equal to i. Note that integers in array can be negative.

Examples:

  Input: arr[] = {-10, -5, 0, 3, 7}
  Output: 3  // arr[3] == 3 

  Input: arr[] = {0, 2, 5, 8, 17}
  Output: 0  // arr[0] == 0 


  Input: arr[] = {-10, -5, 3, 4, 7, 9}
  Output: -1  // No Fixed Point
  */

namespace Programming.Array
{
    public class FixedPointInArray
    {
        public int FindFixedPointInArray(int[] a)
        {
            int i = 0;
            for (; i < a.Length; i++)
                if (a[i] == i)
                    return i;

            return -1;
        }

        public int BinarySearch(int []a,int low,int high)
        {
            if (high >= low)
            {
                int mid = (high + low) / 2;
                if (mid == a[mid])
                    return mid;
                if (mid > a[mid])
                    return BinarySearch(a, mid + 1, high);
                else
                    return BinarySearch(a, low, mid - 1);
            }
            return -1;
        }
        public int FindFixedPointInArray1(int[] a)
        {
            int low = 0, high = a.Length-1;
            return BinarySearch(a, low, high);
        }

        /*public static void Main(string [] args)
        {
            int[] a = new int[] { -10, -1, 0, 3, 10, 11, 30, 50, 100 };
            FixedPointInArray obj = new FixedPointInArray();
            var result = obj.FindFixedPointInArray1(a);
        }*/
    }
}
