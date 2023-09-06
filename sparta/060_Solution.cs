using System;

public class Solution060
{
    public int[] solution(string[] wallpaper)
    {
        int[] answer = new int[4];

        answer[0] = Int32.MaxValue;
        answer[1] = Int32.MaxValue;
        answer[2] = Int32.MinValue;
        answer[3] = Int32.MinValue;

        for (int i = 0; i < wallpaper.Length; i++)
        {
            string str = wallpaper[i];

            for (int j = 0; j < str.Length; j++)
            {
                char ch = str[j];

                if (ch == '#')
                {
                    if (i < answer[0])
                        answer[0] = i;
                    if (j < answer[1])
                        answer[1] = j;
                    if (i + 1 > answer[2])
                        answer[2] = i + 1;
                    if (j + 1 > answer[3])
                        answer[3] = j + 1;
                }
            }
        }
        return answer;
    }
}