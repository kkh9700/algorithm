using System.Text;
using System.Globalization;

public class Solution031
{
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();
        string[] words = s.Split(" ");

        for (int j = 0; j < words.Length; j++)
        {
            string word = words[j];

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(char.ToUpper(word[i]));
                }
                else
                {
                    sb.Append(char.ToLower(word[i]));
                }
            }

            if (j != words.Length - 1)
                sb.Append(" ");
        }

        return sb.ToString();
    }
}