using System;

public class Solution069
{
    public int[] solution(int brown, int yellow)
    {
        int sum = brown + yellow;

        for (int i = 1; i * i <= yellow; i++)
        {
            if (i * i == yellow)
            {
                if ((i + 2) * (i + 2) == sum)
                    return new int[] { i + 2, i + 2 };
            }
            else if (yellow % i == 0)
            {
                if ((i + 2) * (yellow / i + 2) == sum)
                {
                    int x = i > yellow / i ? i + 2 : yellow / i + 2;
                    int y = i > yellow / i ? yellow / i + 2 : i + 2;

                    return new int[] { x, y };
                }
            }
        }


        return new int[] { 0, 0 };
    }


}