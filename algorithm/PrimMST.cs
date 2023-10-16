using System;
using System.Collections.Generic;

public class PrimMST
{
    public PrimMST(int N, string[] input, int start)
    {
        Graph graph = new Graph(N);

        foreach (string str in input)
        {
            string[] split = str.Split(" ");

            int from = Convert.ToInt32(split[0]);
            int to = Convert.ToInt32(split[1]);
            int weight = Convert.ToInt32(split[2]);

            graph.insert(from, to, weight);
        }

        PriorityQueue<Edge, int> pq = new PriorityQueue<Edge, int>();

        bool[] isVisited = new bool[N];

        pq.Enqueue(new Edge(start, 0), 0);

        int sum = 0;

        while (pq.Count != 0)
        {
            Edge edge = pq.Dequeue();
            int v = edge.to;
            int weight = edge.weight;

            if (isVisited[v])
                continue;

            isVisited[v] = true;
            sum += weight;

            List<Edge> edges = graph.get(v);

            foreach (Edge e in edges)
            {
                if (!isVisited[e.to])
                    pq.Enqueue(e, e.weight);
            }
        }

        Console.WriteLine(sum);
    }
}