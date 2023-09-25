using System;

public class Solution084
{
    int answer = 0;

    public int solution(int[] numbers, int target)
    {

        dfs(0, 0, numbers, target);

        return answer;
    }

    public void dfs(int cnt, int sum, int[] numbers, int target)
    {
        if (cnt == numbers.Length)
        {
            if (sum == target)
                answer++;
            return;
        }

        dfs(cnt + 1, sum + numbers[cnt], numbers, target);
        dfs(cnt + 1, sum - numbers[cnt], numbers, target);
    }
}