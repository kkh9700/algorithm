using System;
using System.Collections.Generic;

public class Solution088
{
    public int[] solution(int[] numbers)
    {
        int length = numbers.Length;
        int[] answer = new int[length];

        var stack = new Stack<Item>();

        for (int i = 0; i < length; i++)
        {
            int n = numbers[i];

            while (stack.Count > 0 && numbers[i] > stack.Peek().Value)
            {
                Item top = stack.Pop();
                answer[top.Index] = numbers[i];
            }

            stack.Push(new Item(i, n));
        }

        while (stack.Count > 0)
        {
            Item top = stack.Pop();
            answer[top.Index] = -1;
        }

        return answer;
    }
}

public class Item
{
    public int Index;
    public int Value;

    public Item(int index, int value)
    {
        Index = index;
        Value = value;
    }
}