using System;
using System.Collections.Generic;
using System.Linq;

public class Solution089
{
    public int solution(int[] topping)
    {
        int answer = 0;

        Dictionary<int, int> me = topping.GroupBy(x => x).ToDictionary(y => y.Key, y => y.Count());
        Dictionary<int, int> bro = new Dictionary<int, int>();

        foreach (int n in topping)
        {
            if (bro.ContainsKey(n))
            {
                bro[n]++;
            }
            else
            {
                bro.Add(n, 1);
            }

            me[n]--;

            if (me[n] == 0)
            {
                me.Remove(n);
            }

            if (me.Count == bro.Count)
                answer++;
        }

        return answer;
    }
}