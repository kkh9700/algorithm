using System;
using System.Text;

public class Solution085
{
    public int solution(int n, int k)
    {
        int answer = 0;

        string baseK = DecimalToK(n, k);
        Console.WriteLine(baseK);

        string[] array = baseK.Split("0");

        foreach (string str in array)
        {
            if ("".Equals(str))
                continue;

            long num = Convert.ToInt64(str);

            if (num == 1)
                continue;

            if (isPrime(num))
                answer++;
        }

        return answer;
    }

    public bool isPrime(long n)
    {
        for (long i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    public string DecimalToK(int n, int k)
    {
        StringBuilder sb = new StringBuilder();

        while (n > 0)
        {
            sb.Insert(0, n % k);
            n /= k;
        }
        return sb.ToString();
    }
}