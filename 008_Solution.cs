public class Solution008
{
    public int solution(string s)
    {
        int answer = 0;
        bool minus = false;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '-')
            {
                minus = true;
            }
            else if (c == '+')
            {
                continue;
            }
            else
            {
                answer *= 10;
                answer += (c - '0');
            }

        }

        return minus ? -answer : answer;
    }
}