public class Solution002
{
    public double solution(int[] arr)
    {
        double sum = 0;
        int length = arr.Length;

        for (int i = 0; i < length; i++)
        {
            sum += arr[i];
        }

        return sum / length;
    }
}