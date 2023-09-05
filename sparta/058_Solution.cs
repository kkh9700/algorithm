using System;
using System.Collections.Generic;

public class Solution058
{
    public int solution(int[] ingredient)
    {
        int answer = 0;
        int[] orders = new int[] { 1, 3, 2, 1 };
        Stack<int> wait = new Stack<int>();

        foreach (int i in ingredient)
        {
            wait.Push(i);

            int order = 0;

            while (true)
            {
                int peek = 0;

                if (wait.TryPeek(out peek) && orders[order] == peek)
                {
                    wait.Pop();
                    order++;
                }
                else
                {
                    for (int j = order - 1; j >= 0; j--)
                        wait.Push(orders[j]);

                    break;
                }

                if (order == 4)
                {
                    answer++;
                    order = 0;
                }
            }
        }

        return answer;
    }
}