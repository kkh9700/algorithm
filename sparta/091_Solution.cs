using System;

public class Solution091
{
    public long[] solution(long[] numbers)
    {
        int length = numbers.Length;
        long[] answer = new long[length];

        for (int i = 0; i < length; i++)
        {
            string str = Convert.ToString(numbers[i], 2);

            int idx = str.LastIndexOf('0');

            if (idx == -1)
            {
                str = "1" + str;
                idx = 0;
            }
            else
            {
                str = str.Substring(0, idx) + "1" + str.Substring(idx + 1);
            }

            if (numbers[i] % 2 == 1)
            {
                str = str.Substring(0, idx + 1) + "0" + str.Substring(idx + 2);
            }

            answer[i] = Convert.ToInt64(str, 2);
        }

        return answer;
    }
}