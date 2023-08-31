public class Solution013
{
    public int solution(int num)
    {
        int answer = 0;
        long l = num;
        while (l != 1)
        {
            if (l % 2 == 0)
                l /= 2;
            else
                l = l * 3 + 1;

            answer++;

            if (answer == 500)
                return -1;
        }


        return answer;
    }
}