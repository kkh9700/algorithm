using System;
using System.Collections.Generic;

public class Solution092
{
    public class Through
    {
        public int weight;
        public int length;

        public Through(int weight, int length)
        {
            this.weight = weight;
            this.length = length;
        }


    }
    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        int answer = 1, idx = 0, limit = 0;
        Queue<Through> queue = new Queue<Through>();
        while (true)
        {
            answer++;

            if (truck_weights.Length > idx && limit + truck_weights[idx] <= weight)
            {
                limit += truck_weights[idx];
                queue.Enqueue(new Through(truck_weights[idx++], 0));
            }

            int cnt = queue.Count;

            for (int i = 0; i < cnt; i++)
            {
                Through through = queue.Dequeue();
                through.length++;

                if (through.length == bridge_length)
                {
                    limit -= through.weight;
                }
                else
                {
                    queue.Enqueue(through);
                }
            }

            if (truck_weights.Length == idx && queue.Count == 0)
                break;
        }

        return answer;
    }
}