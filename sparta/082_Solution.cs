using System;
using System.Collections.Generic;

public class Solution082
{
    public int solution(int[] priorities, int location)
    {
        Queue<int> queue = new Queue<int>();

        foreach (int n in priorities)
        {
            queue.Enqueue(n);
        }

        Array.Sort(priorities);
        Array.Reverse(priorities);

        int index = 0;

        while (queue.Count != 0)
        {
            int q = queue.Dequeue();
            Console.WriteLine(index + ": " + q);
            if (priorities[index] == q)
            {
                index++;

                if (location == 0)
                    return index;
            }
            else
            {
                queue.Enqueue(q);
            }


            if (location == 0)
                location = queue.Count;
            location--;
        }


        return 0;
    }
}