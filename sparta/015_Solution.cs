using System;
using System.Collections;

public class Solution015
{
    public int[] solution(int[] arr, int divisor)
    {
        ArrayList list = new ArrayList();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                list.Add(arr[i]);
            }
        }

        list.Sort();

        if (list.Count == 0)
            return new int[] { -1 };

        return (int[])list.ToArray(typeof(int));
    }
}