/*
Given a string, find its first non-repeating character
Given a string, find the first non-repeating character in it. For example, if the input string is “GeeksforGeeks”, then output should be ‘f’ and if input string is “GeeksQuiz”, then output should be ‘G’.*/

using System;
using System.Collections.Generic;

namespace Programming.String
{
    public class FirstNonRepeatingCharacter
    {
        public char FirstNonRepeatingChar(string s)
        {
            char result = " "[0];
            int[] array = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                array[s[i]]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (array[s[i]] == 1)
                    return s[i];
            }
            return result;
        }
        public char FirstNonRepeatingChar1(string s)
        {
            char result = " "[0];
            var map = new Dictionary<char, Tuple<int, int>>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                    map.Add(s[i], new Tuple<int, int>(i, 1));
                else
                {
                    var t = map[s[i]];
                    map[s[i]] = new Tuple<int, int>(t.Item1,t.Item2+1);
                }
            }
            foreach(var t in map)
            {
                if (t.Value.Item2 == 1)
                    return t.Key;
            }
            return result;
        }
        /*public static void Main(string[] args)
        {
            FirstNonRepeatingCharacter obj = new FirstNonRepeatingCharacter();
            var result = obj.FirstNonRepeatingChar1("GeeksForGeeks");
        }*/
    }
}
