public class Solution027
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int l1 = arr1.GetLength(0), l2 = arr1.GetLength(1);
        int[,] answer = new int[l1, l2];

        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }

        return answer;
    }
}