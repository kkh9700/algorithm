using System;
using System.Collections;
using System.Collections.Generic;

public class Solution061
{
    public int[] solution(string today, string[] terms, string[] privacies)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        Date now = new Date(today);

        foreach (string s in terms)
        {
            string type = s.Split(" ")[0];
            int period = Convert.ToInt32(s.Split(" ")[1]);

            dic.Add(type, period);
        }

        List<int> answer = new List<int>();

        for (int i = 0; i < privacies.Length; i++)
        {
            Date date = new Date(privacies[i].Split(" ")[0]);

            date.AddMonth(dic[privacies[i].Split(" ")[1]]);

            if (now.Compare(date))
            {
                answer.Add(i + 1);
            }
        }


        return answer.ToArray();
    }

}

public class Date
{
    int Year;
    int Month;
    int Day;

    public Date(string s)
    {
        Year = Convert.ToInt32(s.Split('.')[0]);
        Month = Convert.ToInt32(s.Split('.')[1]);
        Day = Convert.ToInt32(s.Split('.')[2]);
    }

    public int GetYear() { return Year; }
    public int GetMonth() { return Month; }
    public int GetDay() { return Day; }

    public void AddMonth(int month)
    {
        Month += month;

        while (Month > 12)
        {
            Year++;
            Month -= 12;
        }
    }

    public bool Compare(Date date)
    {
        return Year == date.GetYear() ? (Month == date.GetMonth() ? (Day == date.GetDay() ? true : Day > date.GetDay()) : Month > date.GetMonth()) : Year > date.GetYear();
    }

    public override string ToString()
    {
        return Year + "." + Month + "." + Day;
    }
}