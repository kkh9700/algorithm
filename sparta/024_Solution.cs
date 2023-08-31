using System.Linq;

public class Solution024
{
    public string solution(string s)
    {
        return string.Concat(s.OrderByDescending(ch => ch));
    }
}