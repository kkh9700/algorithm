using System;
using System.Collections.Generic;

public class Solution087
{
    public int solution(string word)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        dic.Add('A', 0);
        dic.Add('E', 1);
        dic.Add('I', 2);
        dic.Add('O', 3);
        dic.Add('U', 4);

        int[] depth = new int[] { 781, 156, 31, 6, 1 };

        int answer = 0;

        for (int i = 0; i < word.Length; i++)
        {
            answer++;
            answer += dic[word[i]] * depth[i];
        }


        return answer;
    }
}