using System;
using System.Text;

public class Solution067
{
    public int[] solution(string s)
    {
        int cnt = 0, zero = 0;
        BinaryConvert(s, out cnt, out zero);

        return new int[] { cnt, zero };
    }

    public void BinaryConvert(string s, out int a, out int b)
    {
        int cnt = 0, sum = 0;
        while (!s.Equals("1"))
        {
            cnt++;
            int length = 0;

            foreach (char ch in s)
            {
                if (ch == '1')
                    length++;
            }

            sum += s.Length - length;

            s = Binary(length);
        }

        a = cnt;
        b = sum;
    }

    public string Binary(int n)
    {
        StringBuilder sb = new StringBuilder();

        while (n != 0)
        {
            sb.Append((n % 2).ToString());
            n /= 2;
        }

        char[] chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }
}