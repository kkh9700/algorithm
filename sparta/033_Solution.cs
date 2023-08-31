using System;

public class Solution033
{
    public int solution(string t, string p)
    {
        int answer = 0, length = p.Length;
        long pnum = Convert.ToInt64(p);

        for (int i = 0; i < t.Length - length + 1; i++)
        {
            long tnum = 0;

            for (int j = 0; j < length; j++)
            {
                tnum *= 10;
                tnum += t[i + j] - '0';
            }


            if (pnum >= tnum)
                answer++;
        }

        return answer;
    }
}