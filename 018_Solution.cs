using System;

public class Solution018
{
    public int solution(int[] numbers)
    {
        int answer = 0;
        bool[] flag = new bool[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            flag[numbers[i]] = true;
        }

        for (int i = 0; i < 10; i++)
        {
            if (!flag[i])
                answer += i;
        }

        return answer;
    }
}