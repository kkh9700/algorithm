using System.Text;

public class Solution020
{
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();
        int length = s.Length;

        if (length % 2 == 0)
        {
            sb.Append(s[length / 2 - 1]);
            sb.Append(s[length / 2]);
        }
        else
        {
            sb.Append(s[length / 2]);
        }

        return sb.ToString();
    }
}