using System;
using System.Collections.Generic;

public class Solution080
{
    public int solution(string[,] clothes)
    {
        Dictionary<string, HashSet<string>> dic = new Dictionary<string, HashSet<string>>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string name = clothes[0, 0], type = clothes[0, 1];
            if (!dic.ContainsKey(type))
            {
                dic[type] = new HashSet<string>();
            }

            dic[type].Add(name);
        }



        return 0;
    }
}