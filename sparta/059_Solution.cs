using System;
using System.Text;

public class Solution059
{
    public string solution(string[] survey, int[] choices)
    {
        StringBuilder sb = new StringBuilder();
        int[] alphabet = new int[26];
        char[,] mbti = new char[,] { { 'R', 'T' }, { 'C', 'F' }, { 'J', 'M' }, { 'A', 'N' } };

        for (int i = 0; i < survey.Length; i++)
        {
            char ch1 = survey[i][0];
            char ch2 = survey[i][1];

            int score = choices[i] - 4;

            if (ch1 < ch2)
            {
                char tmp = ch1;
                ch1 = ch2;
                ch2 = tmp;

                score = -score;
            }

            if (score > 0)
            {
                alphabet[ch2 - 'A'] += score;
            }
            else
            {
                alphabet[ch1 - 'A'] += score;
            }
        }


        for (int i = 0; i < 4; i++)
        {
            int sum = alphabet[mbti[i, 0] - 'A'] + alphabet[mbti[i, 1] - 'A'];

            if (sum < 0)
                sb.Append(mbti[i, 1]);
            else
                sb.Append(mbti[i, 0]);
        }

        return sb.ToString();
    }
}