/*
 * Find if there is a path between two vertices in a directed graph
Given a Directed Graph and two vertices in it, check whether there is a path from the first given vertex to second. For example, in the following graph, there is a path from vertex 1 to 3. As another example, there is no path from 3 to 0.



We can either use Breadth First Search (BFS) or Depth First Search (DFS) to find path between two vertices. Take the first vertex as source in BFS (or DFS), follow the standard BFS (or DFS). If we see the second vertex in our traversal, then return true. Else return false.
*/
using System;
using System.Collections.Generic;

namespace Programming.Graph
{
    public class PathBetweenTwoVerticesInDirectedGraph
    {
        bool IsReachable(Graph g, int s, int d, int v)
        {
            bool[] visited = new bool[v];
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);
            while (queue.Count > 0)
            {
                s = queue.Dequeue();
                foreach (var n in g.adjListArray[s])
                {
                    if (d == n.Item1)
                        return true;
                    if (!visited[n.Item1])
                    {
                        visited[n.Item1] = true;
                        queue.Enqueue(n.Item1);
                    }
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            Graph g = new Graph(4);
            g.IsDirected = true;
            g.addEdge(0, 1, 0);
            g.addEdge(0, 2, 0);
            g.addEdge(1, 2, 0);
            g.addEdge(2, 0, 0);
            g.addEdge(2, 3, 0);
            g.addEdge(3, 3, 0);
            PathBetweenTwoVerticesInDirectedGraph obj = new PathBetweenTwoVerticesInDirectedGraph();
            Console.WriteLine(obj.IsReachable(g, 1, 3, 4));
            Console.WriteLine(obj.IsReachable(g, 3, 1, 4));
        }
    }
}
