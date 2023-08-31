using System;

public class Solution009
{
    public long solution(long n)
    {
        double sqrt = Math.Sqrt(n);

        if (sqrt % 1 != 0)
            return -1;

        return (long)(sqrt + 1) * (long)(sqrt + 1); ;
    }
}