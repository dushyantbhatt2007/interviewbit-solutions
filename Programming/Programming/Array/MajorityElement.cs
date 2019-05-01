/*
 * Majority Element
Write a function which takes an array and prints the majority element (if it exists), otherwise prints “No Majority Element”. A majority element in an array A[] of size n is an element that appears more than n/2 times (and hence there is at most one such element).
Examples :

Input : {3, 3, 4, 2, 4, 4, 2, 4, 4}
Output : 4 

Input : {3, 3, 4, 2, 4, 4, 2, 4}
Output : No Majority Element
*/

namespace Programming.Array
{
    public class MajorityElement
    {
        public int FindMajorityElement(int[] a)
        {
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        index = i;
                    }

                }
                if (count > a.Length / 2)
                    return a[i];
            }
            return -1;
        }
        public int FindMajorityElement1(int[] a)
        {
            int count = 0;
            var candidate = FindCandidate(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == candidate)
                {
                    count++;
                    if (count > a.Length / 2)
                        return candidate;
                }
            }
            return -1;
        }
        private int FindCandidate(int [] a)
        {
            int maj_index = 0,count=1;
            for(int i = 1; i < a.Length; i++)
            {
                if (a[maj_index] == a[i])
                    count++;
                else count--;
                if(count==0)
                {
                    maj_index = i;
                    count = 1;
                }
            }
            return a[maj_index];
        }
        /*public static void Main(string[] args)
        {
            MajorityElement obj = new MajorityElement();
            int[] a = new int[] { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
            var result = obj.FindMajorityElement1(a);
        }*/
    }
}
