public class Solution029
{
    public int[] solution(int n, int m)
    {
        int gcd = GCD(n, m);
        return new int[] { gcd, n * m / gcd };
    }

    // a < b
    public int GCD(int a, int b)
    {
        while (a != 0)
        {
            int n = b % a;
            b = a;
            a = n;
        }

        return b;
    }
}