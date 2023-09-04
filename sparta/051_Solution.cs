using System;

public class Solution051
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] rank = new int[] { 6, 6, 5, 4, 3, 2, 1 };
        int blank = 0, correct = 0;

        for (int i = 0; i < 6; i++)
        {
            if (lottos[i] == 0)
            {
                blank++;
                continue;
            }

            for (int j = 0; j < 6; j++)
            {
                if (lottos[i] == win_nums[j])
                {
                    correct++;
                    continue;
                }
            }
        }

        return new int[] { rank[correct + blank], rank[correct] };
    }
}