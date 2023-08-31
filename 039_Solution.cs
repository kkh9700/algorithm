using System;
using System.Collections.Generic;

public class Solution039
{
    public int[] solution(int[] numbers)
    {
        SortedSet<int> set = new SortedSet<int>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                set.Add(numbers[i] + numbers[j]);
            }
        }

        int[] answer = new int[set.Count];
        set.CopyTo(answer);

        return answer;
    }
}