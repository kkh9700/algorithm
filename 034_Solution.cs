using System;

public class Solution034
{
    public int solution(int[,] sizes)
    {
        int width = 0, height = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 0] < sizes[i, 1])
            {
                int temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }

            if (width < sizes[i, 0])
                width = sizes[i, 0];

            if (height < sizes[i, 1])
                height = sizes[i, 1];
        }

        return width * height;
    }
}