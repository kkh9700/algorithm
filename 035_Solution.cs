using System.Text;

public class Solution035
{
    public string solution(string s, int n)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (ch == ' ') ;
            else if (ch < 'a')
            {
                ch = (char)(ch + n);

                if (ch > 'Z')
                    ch = (char)(ch - 26);
            }
            else
            {
                ch = (char)(ch + n);

                if (ch > 'z')
                    ch = (char)(ch - 26);
            }

            sb.Append(ch);
        }

        return sb.ToString();
    }
}