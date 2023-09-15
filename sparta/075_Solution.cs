using System;
using System.Collections.Generic;

public class Solution075
{
    public int solution(int[] elements)
    {
        int length = elements.Length;
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < length; i++)
        {
            int sum = 0;
            for (int j = 0; j < length; j++)
            {
                int index = (i + j) % length;

                sum += elements[index];

                set.Add(sum);
            }
        }


        return set.Count;
    }
}