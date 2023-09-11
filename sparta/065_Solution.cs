using System;
using System.Linq;
using System.Text;

public class Solution065
{
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();
        int min = Int32.MaxValue, max = Int32.MinValue;


        foreach (string str in s.Split(' '))
        {
            int num = Convert.ToInt32(str);

            if (num > max)
                max = num;

            if (num < min)
                min = num;
        }

        sb.Append(min);
        sb.Append(" ");
        sb.Append(max);

        return sb.ToString();
    }
}