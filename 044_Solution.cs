public class Solution044
{

    public string solution(int a, int b)
    {
        string[] days = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
        int[] dates = new int[] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int sum = 0;

        for (int i = 1; i < a; i++)
        {
            sum += dates[i];
        }

        sum += b;

        return days[(sum + 4) % 7];
    }


}