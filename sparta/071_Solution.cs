public class Solution071
{
    public int solution(int[] arr)
    {
        int num = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            num = GCM(num, arr[i]);
        }

        return num;
    }

    public int GCM(int a, int b)
    {
        return a * b / GCD(a, b);
    }

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