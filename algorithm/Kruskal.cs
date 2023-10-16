// using System;
// using System.Collections.Generic;

// public class Kruskal
// {
//     public Kruskal(int N, string[] input)
//     {
//         List<Edge> edges = new List<Edge>();
//         UnionFind uf = new UnionFind(N);

//         foreach (string str in input)
//         {
//             string[] split = str.Split(" ");

//             int from = Convert.ToInt32(split[0]);
//             int to = Convert.ToInt32(split[1]);
//             int weight = Convert.ToInt32(split[2]);

//             edges.Add(new Edge(from, to, weight));
//         }

//         edges.Sort();

//         int sum = 0;

//         for (int i = 0; i < edges.Count; i++)
//         {
//             if (!uf.isUnion(edges[i].from, edges[i].to))
//             {
//                 sum += edges[i].weight;
//                 uf.Union(edges[i].from, edges[i].to);
//             }
//         }

//         Console.WriteLine(sum);
//     }
// }