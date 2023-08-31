using System;
using System.Text;

public class Solution0030
{
    public int solution(int n)
    {
        return Ternary(Ternary(n));
    }

    public string Ternary(int n)
    {
        StringBuilder sb = new StringBuilder();

        while (n != 0)
        {
            sb.Append(n % 3);
            n /= 3;
        }

        return sb.ToString();
    }

    public int Ternary(string s)
    {
        int num = 0;

        for (int i = 0; i < s.Length; i++)
        {
            num += (int)Math.Pow(3, i) * (s[s.Length - i - 1] - '0');
        }

        return num;
    }
}