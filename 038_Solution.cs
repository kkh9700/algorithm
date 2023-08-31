using System;

public class Solution038
{
    public int[] solution(int[] array, int[,] commands)
    {
        int length = commands.GetLength(0);
        int[] answer = new int[length];

        for (int i = 0; i < length; i++)
        {
            int start = commands[i, 0] - 1, end = commands[i, 1] - 1;
            int[] copy = new int[end - start + 1];

            for (int j = start; j <= end; j++)
            {
                copy[j - start] = array[j];
            }

            Array.Sort(copy);

            answer[i] = copy[commands[i, 2] - 1];
        }
        return answer;
    }
}