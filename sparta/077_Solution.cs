using System;

public class Solution077
{
    public int[] solution(int n, long left, long right)
    {
        long length = right - left + 1;
        int[] answer = new int[length];

        for (long i = left; i < left + length; i++)
        {
            long l = Math.Max(i / n, i % n) + 1;
            answer[i - left] = (int)l;
        }

        return answer;
    }
}