using System.Collections.Generic;

public class Graph
{
    List<Edge>[] edges;

    public Graph(int N)
    {
        edges = new List<Edge>[N];

        for (int i = 0; i < N; i++)
        {
            edges[i] = new List<Edge>();
        }
    }

    public void insert(int from, int to, int weight)
    {
        edges[from].Add(new Edge(to, weight));
    }

    public List<Edge> get(int v)
    {
        return edges[v];
    }
}