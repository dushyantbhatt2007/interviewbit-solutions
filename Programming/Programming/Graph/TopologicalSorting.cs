/*
 * Topological Sorting
Topological sorting for Directed Acyclic Graph (DAG) is a linear ordering of vertices such that for every directed edge uv, vertex u comes before v in the ordering. Topological Sorting for a graph is not possible if the graph is not a DAG.
For example, a topological sorting of the following graph is “5 4 2 3 1 0”. There can be more than one topological sorting for a graph. For example, another topological sorting of the following graph is “4 5 2 3 1 0”. The first vertex in topological sorting is always a vertex with in-degree as 0 (a vertex with no incoming edges).

       3<-- 2<-- 5 -->0 <-- 4 -->1 <--3  

Topological Sorting vs Depth First Traversal (DFS):
In DFS, we print a vertex and then recursively call DFS for its adjacent vertices. In topological sorting, we need to print a vertex before its adjacent vertices. For example, in the given graph, the vertex ‘5’ should be printed before vertex ‘0’, but unlike DFS, the vertex ‘4’ should also be printed before vertex ‘0’. So Topological sorting is different from DFS. For example, a DFS of the shown graph is “5 2 3 1 0 4”, but it is not a topological sorting
*/
using System;
using System.Collections.Generic;

namespace Programming.Graph
{
    public class TopologicalSorting
    {
        public void TopologicalSortUntil(Graph g, bool[] visited, Stack<int> stack, int v)
        {
            visited[v] = true;
            foreach (var i in g.adjListArray[v])
            {
                if (!visited[i.Item1])
                    TopologicalSortUntil(g, visited, stack, i.Item1);
            }
            stack.Push(v);
        }
        public void TopologicalSort(Graph g, int v)
        {
            Stack<int> stack = new Stack<int>();
            bool[] visited = new bool[v];

            for (int i = 0; i < v; i++)
                if(!visited[i])
                    TopologicalSortUntil(g, visited, stack, i);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop().ToString() + " ");
        }
        /*public static void Main(string[] args)
        {
            Graph g = new Graph(6);
            g.IsDirected = true;
            g.addEdge(5, 2, 0);
            g.addEdge(2, 0, 0);
            g.addEdge(4, 0, 0);
            g.addEdge(4, 1, 0);
            g.addEdge(2, 3, 0);
            g.addEdge(3, 1, 0);
            TopologicalSorting obj = new TopologicalSorting();
            obj.TopologicalSort(g, 6);
        }*/
    }
}
