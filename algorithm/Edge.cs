using System;

// public class Edge : IComparable<Edge>
// {
//     public int from { get; private set; }
//     public int to { get; private set; }
//     public int weight { get; private set; }

//     public Edge(int from, int to, int weight)
//     {
//         this.from = from;
//         this.to = to;
//         this.weight = weight;
//     }

//     public int CompareTo(Edge other)
//     {
//         if (weight < other.weight)
//             return -1;
//         if (weight > other.weight)
//             return 1;
//         return 0;
//     }
// }

public class Edge
{
    public int to;
    public int weight;

    public Edge(int to, int weight)
    {
        this.to = to;
        this.weight = weight;
    }
}