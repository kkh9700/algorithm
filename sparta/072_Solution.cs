public class Solution072
{
    public long solution(int n)
    {
        long[] jump = new long[n + 1];
        jump[0] = 1;
        jump[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            jump[i] = (jump[i - 1] + jump[i - 2]) % 1234567;
        }

        return jump[n];
    }
}