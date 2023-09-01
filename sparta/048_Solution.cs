using System;

class Solution048
{
    public int solution(int[] nums)
    {
        int answer = 0, length = nums.Length; ;

        for (int i = 0; i < length - 2; i++)
        {
            for (int j = i + 1; j < length - 1; j++)
            {
                for (int k = j + 1; k < length; k++)
                {
                    int num = nums[i] + nums[j] + nums[k];

                    if (isPrime(num))
                        answer++;
                }
            }
        }

        return answer;
    }

    public bool isPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}