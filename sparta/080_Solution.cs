using System;
using System.Collections.Generic;

public class Solution080
{
    public int solution(string[,] clothes)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];
            if (!dic.ContainsKey(type))
                dic[type] = 0;

            dic[type]++;
        }

        int answer = 1;

        foreach (var v in dic)
        {
            answer *= v.Value + 1;
        }

        return answer - 1;
    }
}