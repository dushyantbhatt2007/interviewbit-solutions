/*
 * Given a sorted dictionary of an alien language, find order of characters
Given a sorted dictionary (array of words) of an alien language, find order of characters in the language.
Examples:

Input:  words[] = {"baa", "abcd", "abca", "cab", "cad"}
Output: Order of characters is 'b', 'd', 'a', 'c'
Note that words are sorted and in the given language "baa" 
comes before "abcd", therefore 'b' is before 'a' in output.
Similarly we can find other orders.

Input:  words[] = {"caa", "aaa", "aab"}
Output: Order of characters is 'c', 'a', 'b'
*/
using System;
using System.Collections.Generic;

namespace Programming.Graph
{
    public class SortedDictionaryOfAlienLanguage
    {
        public void TopologicalSortUntil(Graph g, int i, Stack<int> stack, bool[] visited)
        {
            visited[i] = true;
            foreach (var t in g.adjListArray[i])
            {
                if (!visited[t.Item1])
                {
                    visited[t.Item1] = true;
                    TopologicalSortUntil(g, t.Item1, stack, visited);
                }
            }
            stack.Push(i);
        }
        public void TopologicalSort(Graph g, int v)
        {
            Stack<int> stack = new Stack<int>();
            bool[] visited = new bool[v];

            for (int i = 0; i < v; i++)
            {
                if (!visited[i])
                    TopologicalSortUntil(g, i, stack, visited);
            }
            while (stack.Count > 0)
                Console.WriteLine((char)('a' + stack.Pop()) + " ");
        }

        public void PrintOrder(string[] words, int aplha)
        {
            Graph g = new Graph(aplha);
            g.IsDirected = true;
            for (int i = 0; i < words.Length - 1; i++)
            {
                var word1 = words[i];
                var word2 = words[i + 1];
                for (int j = 0; j < Math.Min(word1.Length, word2.Length); j++)
                {
                    if (word1[j] != word2[j])
                    {
                        g.addEdge(word1[j] - 'a', word2[j] - 'a', 0);
                        break;
                    }
                }
            }
            TopologicalSort(g, aplha);
        }
        /*public static void Main(string[] args)
        {
            string[] words = { "baa", "abcd", "abca", "cab", "cad" };
            SortedDictionaryOfAlienLanguage obj = new SortedDictionaryOfAlienLanguage();
            obj.PrintOrder(words, 4);
        }*/
    }
}
