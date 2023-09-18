using System;
using System.ComponentModel;

public class Solution078
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int length1 = arr1.GetLength(0), length2 = arr2.GetLength(1);
        int[,] answer = new int[length1, length2];

        for (int i = 0; i < length1; i++)
        {
            for (int j = 0; j < length2; j++)
            {
                int num = 0;

                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    num += arr1[i, k] * arr2[k, j];
                }


                answer[i, j] = num;
            }
        }

        return answer;
    }
}