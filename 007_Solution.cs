using System;

public class Solution007
{
    public int[] solution(long n)
    {
        int length = (int)Math.Floor(Math.Log10(n) + 1);
        int[] answer = new int[length];

        for (int i = 0; i < length; i++)
        {
            answer[i] = (int)(n % 10);
            n /= 10;
        }

        return answer;
    }
}