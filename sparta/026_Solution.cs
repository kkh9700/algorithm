using System;

public class Solution026
{
    public bool solution(string s)
    {
        if (!(s.Length == 4 || s.Length == 6))
            return false;

        foreach (char ch in s)
        {
            if (ch < '0' || ch > '9')
                return false;
        }

        return true;
    }
}