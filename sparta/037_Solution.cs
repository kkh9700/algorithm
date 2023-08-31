using System;

public class Solution037
{
    public string[] solution(string[] strings, int n)
    {
        Array.Sort(strings,
                    new Comparison<string>((s1, s2) =>
                                           s1[n].CompareTo(s2[n]) == 0 ? s1.CompareTo(s2) : s1[n].CompareTo(s2[n])
        ));
        return strings;
    }
}