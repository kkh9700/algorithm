public class Solution054
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;
        int[] students = new int[n + 1];

        foreach (int i in lost)
            students[i]--;

        foreach (int i in reserve)
            students[i]++;

        for (int i = 1; i <= n; i++)
        {
            bool flag = true;

            if (i != 1 && students[i] == -1 && students[i - 1] == 1)
            {
                students[i]++;
                students[i - 1]--;
            }

            if (i != n && students[i] == -1 && students[i + 1] == 1)
            {
                students[i]++;
                students[i + 1]--;
            }

            if (students[i] >= 0)
                answer++;
        }

        return answer;
    }
}