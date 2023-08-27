using System;

public class Solution010
{
    public long solution(long n)
    {
        int length = (int)Math.Floor(Math.Log10(n) + 1);
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = (int)(n % 10);
            n /= 10;
        }

        Array.Sort(array);

        long answer = 0;

        for (int i = length - 1; i >= 0; i--)
        {
            answer *= 10;
            answer += array[i];
        }

        return answer;
    }
}