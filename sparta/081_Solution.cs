using System;
using System.Collections.Generic;
public class Solution081
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        int length = progresses.Length;

        List<int> list = new List<int>();

        int max = Int32.MinValue, cnt = 0;

        for (int i = 0; i < length; i++)
        {
            int day = (100 - progresses[i]) / speeds[i] + ((100 - progresses[i]) % speeds[i] == 0 ? 0 : 1);
            if (max < day)
            {
                max = day;
                if (i != 0)
                    list.Add(cnt);
                cnt = 1;
            }
            else
            {
                cnt++;
            }
        }

        list.Add(cnt);


        return list.ToArray();
    }
}