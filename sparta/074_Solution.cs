using System;
using System.Collections.Generic;

public class Solution074
{
    public int solution(string s)
    {
        int answer = 0;
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dic = new Dictionary<char, char>();
        dic.Add(')', '(');
        dic.Add('}', '{');
        dic.Add(']', '[');

        if (s.Length % 2 == 1)
            return 0;

        for (int i = 0; i < s.Length; i++)
        {
            stack.Clear();
            int cnt = 0;

            for (int j = i; j < i + s.Length; j++)
            {
                int index = j % s.Length;

                char c = s[index];

                if (!dic.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    char match;

                    if (!stack.TryPeek(out match))
                        break;

                    if (match != dic[c])
                        break;

                    stack.Pop();
                    cnt++;
                }
            }

            if (cnt == s.Length / 2)
                answer++;
        }

        return answer;
    }
}