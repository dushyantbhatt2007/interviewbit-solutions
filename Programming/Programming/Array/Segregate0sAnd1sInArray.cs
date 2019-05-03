/*
Segregate 0s and 1s in an array
You are given an array of 0s and 1s in random order. Segregate 0s on left side and 1s on right side of the array. Traverse array only once.
Input array   =  [0, 1, 0, 1, 0, 0, 1, 1, 1, 0] 
Output array =  [0, 0, 0, 0, 0, 1, 1, 1, 1, 1] 
*/

namespace Programming.Array
{
    public class Segregate0sAnd1sInArray
    {
        public int[] Segregate0sAnd1s(int[] a)
        {
            int l = 0, r = a.Length - 1;
            while (l < r)
            {
                if (a[l] == 0)
                    l++;
                if (a[r] == 1)
                    r--;
                if (a[l] == 1 && a[r] == 0)
                {
                    a[l] = 0; a[r] = 1;
                    l++; r--;
                }
            }
            return a;
        }
        /*public static void Main(string[] args)
        {
            Segregate0sAnd1sInArray obj = new Segregate0sAnd1sInArray();
            int[] a = new int[] { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 1 };
            var result = obj.Segregate0sAnd1s(a);
        }*/
    }
}
