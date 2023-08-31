using System;

public class Solution005
{
    public int solution(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if ((n - 1) % i == 0)
                return i;
        }

        return -1;
    }
}