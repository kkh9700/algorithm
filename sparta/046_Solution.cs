using System;

public class Solution046
{
    public int solution(int k, int m, int[] score)
    {
        Array.Sort(score);
        Array.Reverse(score);

        int answer = 0;

        for (int i = 0; i < score.Length / m; i++)
        {
            answer += score[i * m + m - 1] * m;
        }

        return answer;
    }
}