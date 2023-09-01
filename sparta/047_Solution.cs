using System;
using System.Linq;
using System.Collections.Generic;

public class Solution047
{
    public int[] solution(int[] answers)
    {
        int[] st1 = { 1, 2, 3, 4, 5 };
        int[] st2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] st3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] solve = new int[3];

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == st1[i % 5]) solve[0]++;
            if (answers[i] == st2[i % 8]) solve[1]++;
            if (answers[i] == st3[i % 10]) solve[2]++;
        }

        int max = solve.Max();

        if (max == 0)
            return new int[] { };

        List<int> answer = new List<int>();

        if (solve[0] == max) answer.Add(1);
        if (solve[1] == max) answer.Add(2);
        if (solve[2] == max) answer.Add(3);

        return (int[])answer.ToArray();
    }
}