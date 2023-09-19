using System;
using System.Collections.Generic;

public class Solution079
{
    Dictionary<string, int> dic = new Dictionary<string, int>();
    public int solution(string[] want, int[] number, string[] discount)
    {
        int answer = 0;
        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < want.Length; i++)
        {
            dic[want[i]] = number[i];
        }

        for (int i = 0; i < discount.Length; i++)
        {
            string s = discount[i];

            if (dic.ContainsKey(s))
                dic[s] = dic[s] - 1;

            if (i > 9)
            {
                s = discount[i - 10];

                if (dic.ContainsKey(s))
                    dic[s] = dic[s] + 1;
            }

            if (i > 8)
                if (CheckNumber(dic))
                    answer++;

        }

        return answer;
    }

    bool CheckNumber(Dictionary<string, int> dic)
    {
        bool b = false;
        foreach (int i in dic.Values)
        {
            if (i != 0)
            {
                b = false;
                break;
            }
            else { b = true; }
        }
        return b;
    }
}