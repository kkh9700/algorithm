using System;

public class Solution055
{
    public int solution(string s)
    {
        int answer = 0;

        int cnt = 0;
        char x = ' ';


        foreach (char ch in s)
        {
            if (cnt == 0)
            {
                x = ch;
                cnt++;
                answer++;
            }
            else
            {
                if (ch == x)
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                }
            }
        }

        return answer;
    }
}