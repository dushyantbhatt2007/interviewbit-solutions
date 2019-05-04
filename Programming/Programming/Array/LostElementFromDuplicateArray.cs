/*
 * Find lost element from a duplicated array
Given two arrays which are duplicates of each other except one element, that is one element from one of the array is missing, we need to find that missing element.

Examples:

Input:  arr1[] = {1, 4, 5, 7, 9}
        arr2[] = {4, 5, 7, 9}
Output: 1
1 is missing from second array.

Input: arr1[] = {2, 3, 4, 5}
       arr2[] = {2, 3, 4, 5, 6}
Output: 6
6 is missing from first array.
*/

namespace Programming.Array
{
    public class LostElementFromDuplicateArray
    {
        public int FindLostElement(int[] a, int[] b, int n)
        {
            if (n == 1)
                return a[0];

            if (a[0] != b[0])
                return a[0];

            int low = 0, high = n - 1;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (a[mid] == b[mid])
                    low = mid;
                else
                    high = mid;
                if (low == high - 1)
                    break;
            }
            return a[high];
        }
        /*public static void Main(string[] args)
        {
            LostElementFromDuplicateArray obj = new LostElementFromDuplicateArray();
            int[] a = new int[] { 2, 3, 4, 5 };
            int[] b = new int[] { 2, 3, 4, 5, 6 };
            int result;
            if (a.Length > b.Length)
                result = obj.FindLostElement(a, b, a.Length);
            else
                result = obj.FindLostElement(b, a, b.Length);
        }*/
    }
}
