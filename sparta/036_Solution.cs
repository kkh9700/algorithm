using System;

public class Solution036
{
    public int solution(string s)
    {
        string[] number = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < 10; i++)
        {
            s = s.Replace(number[i].ToString(), i.ToString());
        }

        return Convert.ToInt32(s);
    }
}