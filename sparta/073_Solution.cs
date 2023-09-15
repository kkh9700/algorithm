using System;
using System.Linq;

public class Solution073
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0, sum = 0;

        var a = tangerine.GroupBy(g => g).
            Select(s => s.Count()).
            OrderByDescending(o => o).
            ToList();

        foreach (var b in a)
        {
            answer++;
            sum += b;
            if (sum >= k)
                break;
        }

        return answer;
    }
}