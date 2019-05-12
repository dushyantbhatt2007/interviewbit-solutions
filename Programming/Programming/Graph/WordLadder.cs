/*
 * Word Ladder (Length of shortest chain to reach a target word)
Given a dictionary, and two words ‘start’ and ‘target’ (both of same length). Find length of the smallest chain from ‘start’ to ‘target’ if it exists, such that adjacent words in the chain only differ by one character and each word in the chain is a valid word i.e., it exists in the dictionary. It may be assumed that the ‘target’ word exists in dictionary and length of all dictionary words is same.

Example:

Input:  Dictionary = {POON, PLEE, SAME, POIE, PLEA, PLIE, POIN}
             start = TOON
             target = PLEA
Output: 7
Explanation: TOON - POON - POIN - POIE - PLIE - PLEE - PLEA
*/
using System.Collections.Generic;

namespace Programming.Graph
{
    public class WordLadder
    {
        public class QItem
        {
            public string word;
            public int len;
            public QItem(string word, int len)
            {
                this.word = word;
                this.len = len;
            }
        }
        public bool IsAdjacent(string a, string b)
        {
            int count = 0, len = a.Length;
            for (int i = 0; i < len; i++)
            {
                if (a[i] != b[i])
                    count++;
                if (count > 1)
                    return false;
            }
            return count == 1 ? true : false;
        }
        public int ShortestChain(string start, string target, List<string> words)
        {
            Queue<QItem> queue = new Queue<QItem>();
            queue.Enqueue(new QItem(start, 1));
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                for (int i = 0; i < words.Count; i++)
                {
                    var temp = words[i];
                    if (IsAdjacent(curr.word, temp))
                    {
                        queue.Enqueue(new QItem(temp, curr.len + 1));
                        words.Remove(temp);
                        if (temp == target)
                            return curr.len + 1;
                    }
                }
            }
            return 0;
        }
        /*public static void Main(string[] args)
        {
            List<string> words = new List<string>();
            words.Add("poon");
            words.Add("plee");
            words.Add("same");
            words.Add("poie");
            words.Add("plie");
            words.Add("poin");
            words.Add("plea");
            string start = "toon";
            string target = "plea";
            WordLadder obj = new WordLadder();
            var result = obj.ShortestChain(start, target, words);
        }*/
    }
}
