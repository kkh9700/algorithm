using System;

public class Solution056
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];

        int[] alphabet = new int[26];
        Array.Fill(alphabet, Int32.MaxValue);

        foreach (string s in keymap)
        {
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'A';

                if (alphabet[index] > i + 1)
                    alphabet[index] = i + 1;
            }
        }

        for (int i = 0; i < targets.Length; i++)
        {
            int sum = 0;

            foreach (char ch in targets[i])
            {
                int index = ch - 'A';

                if (alphabet[index] == Int32.MaxValue)
                {
                    answer[i] = -1;
                    break;
                }
                else
                {
                    sum += alphabet[index];
                }
            }

            if (answer[i] != -1)
                answer[i] = sum;
        }


        return answer;
    }
}