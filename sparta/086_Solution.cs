using System;
using System.Collections.Generic;
using System.Linq;

public class Solution086
{
    public int[] solution(int[] fees, string[] records)
    {
        Dictionary<string, int> time = new Dictionary<string, int>();

        foreach (string str in records)
        {
            string[] split = str.Split(' ');

            int t = StringToInt(split[0]);
            string carNumber = split[1];
            bool flag = "IN".Equals(split[2]);


            if (time.ContainsKey(carNumber))
            {
                time[carNumber] += t * (flag ? -1 : 1);
            }
            else
            {
                time.Add(carNumber, -t);
            }
        }

        List<string> list = time.Keys.ToList();
        list.Sort();

        int[] answer = new int[list.Count];
        int index = 0;

        foreach (string str in list)
        {
            int t = time[str];

            if (t <= 0)
                t += 1439;


            int fee = fees[1];

            if (fees[0] < t)
            {
                fee += (int)Math.Ceiling((t - fees[0]) / (double)fees[2]) * fees[3];
            }

            answer[index++] = fee;
        }


        return answer;
    }

    public int StringToInt(string str)
    {
        string[] array = str.Split(":");

        int hour = Convert.ToInt32(array[0]);
        int minute = Convert.ToInt32(array[1]);

        return hour * 60 + minute;
    }
}