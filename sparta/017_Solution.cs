using System.Text;

public class Solution017
{
    public string solution(string phone_number)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < phone_number.Length; i++)
        {
            if (i < phone_number.Length - 4)
            {
                sb.Append('*');
            }
            else
            {
                sb.Append(phone_number[i]);
            }
        }

        return sb.ToString();
    }
}