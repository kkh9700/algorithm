using System;

public class Solution049
{
    public int solution(int n, int m, int[] sections)
    {
        int answer = 0, num = 0;

        for (int i = 0; i < sections.Length; i++)
        {
            if (sections[i] > num)
            {
                num = sections[i] + m - 1;
                answer++;
            }
        }

        return answer;
    }
}