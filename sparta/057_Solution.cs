using System;
using System.Text;

public class Solution057
{
    public string solution(string s, string skip, int index)
    {
        StringBuilder sb = new StringBuilder();
        bool[] alphabet = new bool[26];

        foreach (char ch in skip)
        {
            alphabet[charToInt(ch)] = true;
        }

        foreach (char ch in s)
        {
            int num = charToInt(ch);

            for (int i = 0; i < index; i++)
            {
                num = increase(num);

                while (alphabet[num])
                    num = increase(num);
            }

            sb.Append(intToChar(num));
        }

        return sb.ToString();
    }

    public int charToInt(char ch)
    {
        return ch - 'a';
    }

    public char intToChar(int i)
    {
        return (char)('a' + i);
    }

    public int increase(int num)
    {
        num++;

        if (num >= 26)
            num -= 26;

        return num;
    }
}