/*
 * Replace every element with the greatest element on right side
Given an array of integers, replace every element with the next greatest element (greatest element on the right side) in the array. Since there is no element next to the last element, replace it with -1. For example, if the array is {16, 17, 4, 3, 5, 2}, then it should be modified to {17, 5, 5, 5, 2, -1}.
*/
using System;

namespace Programming.Array
{
    public class ReplaceElementWithGreatestElementRightSide
    {
        public int[] ReplaceElements(int[] a)
        {
            int max_element = a[a.Length - 1];
            a[a.Length - 1] = -1;
            for (int i = a.Length - 2; i >= 0; i--)
            {
                var temp = a[i];
                a[i] = max_element;
                max_element = Math.Max(max_element, temp);
            }
            return a;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 16, 17, 4, 3, 5, 2 };
            ReplaceElementWithGreatestElementRightSide obj = new ReplaceElementWithGreatestElementRightSide();
            var result = obj.ReplaceElements(a);
        }*/
    }
}
