using System;

public class Solution052
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        string[] pronunciation = new string[] { "aya", "ye", "woo", "ma" };

        for (int i = 0; i < babbling.Length; i++)
        {
            string str = babbling[i];

            int index = -1;

            while (!str.Equals(""))
            {
                bool flag = true;

                for (int j = 0; j < 4; j++)
                {

                    if (index != j && str.IndexOf(pronunciation[j]) == 0)
                    {
                        index = j;
                        flag = false;
                        str = str.Substring(pronunciation[j].Length);
                    }
                }


                if (flag)
                    break;
            }


            if (str.Equals(""))
                answer++;
        }

        return answer;
    }
}