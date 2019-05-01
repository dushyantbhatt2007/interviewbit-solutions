/*
Find the Missing Number
You are given a list of n-1 integers and these integers are in the range of 1 to n. There are no duplicates in list. One of the integers is missing in the list. Write an efficient code to find the missing integer.

Example :
I/P    [1, 2, 4, ,6, 3, 7, 8]
O/P    5

 */
namespace Programming.Array
{
    public class FindMissingNumberInArray
    {
        public int FindMissingNumber(int[] a)
        {
            int total = (a.Length + 1) * (a.Length + 2) / 2;

            for (int i = 0; i < a.Length; i++)
            {
                total -= a[i];
            }
            return total;
        }
        public int FindMissingNumber1(int[] a)
        {
            int x1 = a[0], x2 = 1;

            for (int i = 1; i < a.Length; i++)
            {
                x1 = x1 ^ a[i];
                if (i > 1)
                    x2 = x2 ^ i;
            }

            for (int i = a.Length; i <= a.Length + 1; i++)
                x2 = x2 ^ i;

            return x1 ^ x2;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[4] { 1, 4, 2, 5 };
            FindMissingNumberInArray obj = new FindMissingNumberInArray();
            var result = obj.FindMissingNumber1(a);
        }*/
    }
}
