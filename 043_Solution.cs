using System.Linq;

public class Solution043
{
    public int[] solution(int k, int[] score)
    {
        int length = score.Length;
        int[] answer = new int[length];
        int[] hallOfFrame = Enumerable.Repeat(-1, k).ToArray(); ;

        for (int i = 0; i < length; i++)
        {
            answer[i] = AddScore(score[i], hallOfFrame);
        }

        return answer;
    }

    public int AddScore(int score, int[] array)
    {
        int min = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < score)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    array[j] = array[j - 1];
                }

                array[i] = score;
                break;
            }
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == -1)
                continue;
            return array[i];
        }

        return 0;
    }
}