using System;
using System.Linq;

public class Solution076
{
    public int solution(int[] citations)
    {
        Array.Sort(citations);

        int answer = 0, length = citations.Length;

        for (int i = 0; i < length; i++)
        {
            if (citations[i] >= length - i)
            {
                answer = length - i;
                break;
            }
        }

        return answer;
    }
}