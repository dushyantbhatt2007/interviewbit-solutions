/*Detect Cycle in a Directed Graph
Given a directed graph, check whether the graph contains a cycle or not. Your function should return true if the given graph contains at least one cycle, else return false. For example, the following graph contains three cycles 0->2->0, 0->1->2->0 and 3->3, so your function must return true.

Recommended: Please solve it on “PRACTICE” first, before moving on to the solution.
Depth First Traversal can be used to detect a cycle in a Graph. DFS for a connected graph produces a tree. There is a cycle in a graph only if there is a back edge present in the graph. A back edge is an edge that is from a node to itself (self-loop) or one of its ancestor in the tree produced by DFS. In the following graph, there are 3 back edges, marked with a cross sign. We can observe that these 3 back edges indicate 3 cycles present in the graph.



For a disconnected graph, we get the DFS forest as output. To detect cycle, we can check for a cycle in individual trees by checking back edges.

To detect a back edge, we can keep track of vertices currently in recursion stack of function for DFS traversal. If we reach a vertex that is already in the recursion stack, then there is a cycle in the tree. The edge that connects current vertex to the vertex in the recursion stack is a back edge. We have used recStack[] array to keep track of vertices in the recursion stack.

*/

namespace Programming.Graph
{
    public class DetectCycleInDirectedGraph
    {
        public bool DetectCycle(Graph g, int v)
        {
            bool[] visited = new bool[v];
            bool[] stack = new bool[v];
            for(int i = 0; i < v; i++)
                if (IsCycleUntil(i, visited, stack, g))
                    return true;

            return false;
        }
        public bool IsCycleUntil(int i, bool[]visited,bool[]stack,Graph g)
        {
            if(visited[i]== false)
            {
                visited[i] = true;
                stack[i] = true;
                foreach(var t in g.adjListArray[i])
                {
                    if (!visited[t.Item1] && IsCycleUntil(t.Item1, visited, stack, g))
                        return true;
                    else if (stack[t.Item1])
                        return true;
                }
            }
            stack[i] = false;
            return false;
        }
        /*public static void Main(string[] args)
        {
            Graph g = new Graph(4);
            g.IsDirected = true;
            g.addEdge(0, 1, 0);
            g.addEdge(1, 2, 0);
            g.addEdge(2, 0, 0);
            g.addEdge(2, 3, 0);
            g.addEdge(3, 3, 0);
            DetectCycleInDirectedGraph obj = new DetectCycleInDirectedGraph();
            var result = obj.DetectCycle(g, 4);
        }*/
    }
}
