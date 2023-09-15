public class Solution068
{
    public int solution(int n)
    {
        int[] fib = new int[n + 1];
        fib[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];

            if (fib[i] > 1234567)
                fib[i] %= 1234567;
        }

        return fib[n];
    }
}