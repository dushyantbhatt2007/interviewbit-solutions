/*
Union and Intersection of two sorted arrays
Given two sorted arrays, find their union and intersection.

Example:

Input : arr1[] = {1, 3, 4, 5, 7}
        arr2[] = {2, 3, 5, 6} 
Output : Union : {1, 2, 3, 4, 5, 6, 7} 
         Intersection : {3, 5}

Input : arr1[] = {2, 5, 6}
        arr2[] = {4, 6, 8, 10} 
Output : Union : {2, 4, 5, 6, 8, 10} 
         Intersection : {6}*/
using System;

namespace Programming.Array
{
    public class UnionAndIntersectionOfTwoSortedArray
    {
        //Time complexity O(m+n)
        public int[] Union(int[] a, int[] b)
        {
            int[] U = new int[a.Length + b.Length];
            int len = Math.Max(a.Length, b.Length);
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    U[k++] = a[i++];
                else if (a[i] > b[j])
                    U[k++] = b[j++];
                else
                {
                    U[k++] = b[j++];
                    i++;
                }
                if (k > 1 && U[k - 1] == U[k - 2])
                    U[--k] = 0;
            }
            while (i < a.Length)
            {
                U[k++] = a[i++];
                if (k > 1 && U[k - 1] == U[k - 2])
                    U[--k] = 0;
            }

            while (j < b.Length)
            {
                U[k++] = b[j++];
                if (k > 1 && U[k - 1] == U[k - 2])
                    U[--k] = 0;
            }
            return U;
        }
        public int[] Intersection(int[] a, int[] b)
        {
            int len = Math.Min(a.Length, b.Length);
            int[] I = new int[len];
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    i++;
                else if (a[i] > b[j])
                    j++;
                else
                {
                    I[k++] = b[j++];
                    i++;
                }
                if (k > 1 && I[k - 1] == I[k - 2])
                    I[--k] = 0;
            }
            return I;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 5, 6, 7 };
            int[] b = new int[2] { 6, 6 };
            UnionAndIntersectionOfTwoSortedArray obj = new UnionAndIntersectionOfTwoSortedArray();
            var union = obj.Union(a, b);
            var intersection = obj.Intersection(a, b);
        }*/
    }
}
