public class Solution066
{
    public string solution(string s)
    {
        int index = 0;
        string answer = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                index = 0;
                answer += s[i];
                continue;
            }

            if (index == 0 && s[i] >= 'a')
            {
                answer += (char)(s[i] - 32);
            }
            else if (index != 0 && s[i] <= 'Z')
            {
                answer += (char)(s[i] + 32);
            }
            else
            {
                answer += s[i];
            }

            index++;
        }

        return answer;
    }
}