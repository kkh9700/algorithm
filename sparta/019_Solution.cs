using System.Collections;

public class Solution019
{
    public int[] solution(int[] arr)
    {
        if (arr.Length == 1)
            return new int[] { -1 };

        ArrayList list = new ArrayList(arr);

        list.Sort();

        int[] answer = new int[arr.Length - 1];
        int min = (int)list[0];
        int idx = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != min)
                answer[idx++] = arr[i];
        }

        return answer;
    }
}