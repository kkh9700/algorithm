using System.Text;

public class Solution041
{
    public string solution(int[] food)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i < food.Length; i++)
        {
            for (int j = 0; j < food[i] / 2; j++)
            {
                sb.Append(i);
            }
        }

        sb.Append("0");

        for (int i = food.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < food[i] / 2; j++)
            {
                sb.Append(i);
            }
        }

        return sb.ToString();
    }
}