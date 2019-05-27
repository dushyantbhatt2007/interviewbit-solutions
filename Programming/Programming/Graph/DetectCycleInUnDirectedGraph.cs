/*
Detect cycle in an undirected graph
.
Given an undirected graph, how to check if there is a cycle in the graph? For example, the following graph has a cycle 1-0-2-1.
cycleGraph


We have discussed cycle detection for directed graph. We have also discussed a union-find algorithm for cycle detection in undirected graphs. The time complexity of the union-find algorithm is O(ELogV). Like directed graphs, we can use DFS to detect cycle in an undirected graph in O(V+E) time. We do a DFS traversal of the given graph. For every visited vertex ‘v’, if there is an adjacent ‘u’ such that u is already visited and u is not parent of v, then there is a cycle in graph. If we don’t find such an adjacent for any vertex, we say that there is no cycle. The assumption of this approach is that there are no parallel edges between any two vertices.
*/

namespace Programming.Graph
{
    public class DetectCycleInUnDirectedGraph
    {

        public bool DetectCycle(Graph g, int v)
        {
            bool[] visited = new bool[v];

            for (int i = 0; i < v; i++)
                if (!visited[i])
                    if (IsCycleUntil(g, i, visited, -1))
                        return true;
            return false;
        }
        public bool IsCycleUntil(Graph g, int i, bool[] visited, int parent)
        {
            visited[i] = true;
            foreach (var t in g.adjListArray[i])
            {
                if (!visited[t.Item1])
                {
                    if (IsCycleUntil(g, t.Item1, visited, i))
                        return true;
                }
                else if (t.Item1 != parent)
                    return true;
            }
            return false;
        }
        /*public static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.addEdge(0, 1, 0);
            g.addEdge(0, 3, 0);
            g.addEdge(0, 2, 0);
            g.addEdge(3, 4, 0);
            g.addEdge(1, 2, 0);
            DetectCycleInUnDirectedGraph obj = new DetectCycleInUnDirectedGraph();
            var result = obj.DetectCycle(g, 5);
        }*/
    }
}
