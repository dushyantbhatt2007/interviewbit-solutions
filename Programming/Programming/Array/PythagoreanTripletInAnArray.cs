/*
Pythagorean Triplet in an array
Given an array of integers, write a function that returns true if there is a triplet(a, b, c) that satisfies a2 + b2 = c2.
Example:

Input: arr[] = {3, 1, 4, 6, 5}
Output: True
There is a Pythagorean triplet(3, 4, 5).

Input: arr[] = {10, 4, 6, 12, 5}
Output: False
There is no Pythagorean triplet.
*/

namespace Programming.Array
{
    public class PythagoreanTripletInAnArray
    {
        public bool isTriplet(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {

                        // Calculate square of array elements 
                        int x = a[i] * a[i], y = a[j] * a[j], z = a[k] * a[k];

                        if (x == y + z || y == x + z || z == x + y)
                            return true;
                    }
                }
            }

            // If we reach here, no triplet found 
            return false;
        }
        public bool isTriplet1(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
                a[i] = a[i] * a[i];

            System.Array.Sort(a);

            for (int i = n - 1; i >= 2; i--)
            {
                int l = 0;
                int r = i - 1;
                while (l < r)
                {
                    if (a[l] + a[r] == a[i])
                        return true;
                    if (a[l] + a[r] < a[i])
                        l++;
                    else
                        r--;
                }
            }
            return false;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 3, 1, 4, 6, 5 };
            PythagoreanTripletInAnArray obj = new PythagoreanTripletInAnArray();
            var result = obj.isTriplet(a);
            var result2 = obj.isTriplet1(a);
        }*/
    }
}
