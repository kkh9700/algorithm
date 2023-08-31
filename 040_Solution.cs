using System;
using System.Linq;

public class Solution040
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];
        int[] arphabet = Enumerable.Repeat(-1, 26).ToArray();

        for (int i = 0; i < s.Length; i++)
        {
            int index = s[i] - 'a';
            if (arphabet[index] == -1)
                answer[i] = -1;
            else
                answer[i] = i - arphabet[index];
            arphabet[index] = i;
        }

        return answer;
    }
}