using System;

public class Solution032
{
    public int solution(int[] number)
    {
        int answer = 0, sum = 0, length = number.Length;


        for (int i = 0; i < length - 2; i++)
        {
            sum += number[i];

            for (int j = i + 1; j < length - 1; j++)
            {
                sum += number[j];

                for (int k = j + 1; k < length; k++)
                {
                    sum += number[k];

                    if (sum == 0)
                        answer++;

                    sum -= number[k];
                }

                sum -= number[j];
            }

            sum -= number[i];
        }



        return answer;
    }
}