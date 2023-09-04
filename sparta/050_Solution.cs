using System;

public class Solution050
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;

        for (int i = 1; i <= number; i++)
        {
            int atk = divisor(i);

            if (atk > limit)
                atk = power;

            answer += atk;
        }


        return answer;
    }

    public int divisor(int number)
    {
        int result = 0;

        for (int i = 1; i * i <= number; i++)
        {
            if (i * i == number)
                result++;
            else if (number % i == 0)
                result += 2;
        }

        return result;
    }
}