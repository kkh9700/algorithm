using System.Text;
using System.Linq;

public class Solution053
{
    public string solution(string X, string Y)
    {
        StringBuilder sb = new StringBuilder();
        int[] cnt = new int[10];
        int zero = 0;

        foreach (char ch in X)
        {
            cnt[ch - '0']++;
        }

        foreach (char ch in Y)
        {
            if (cnt[ch - '0'] != 0)
            {
                cnt[ch - '0']--;
                sb.Append((char)ch - '0');

                if (ch == '0')
                {
                    zero++;
                }
            }
        }

        if (sb.Length == 0)
            return "-1";

        if (sb.Length == zero)
            return "0";

        return string.Concat(sb.ToString().OrderByDescending(ch => ch));
    }
}