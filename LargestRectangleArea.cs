using System;
using System.Collections.Generic;

public class LRA
{
    public int LargestRectangleArea(int[] heights)
    {
        int answer = 0;
        int width = 0;
        Stack<Point> stack = new Stack<Point>();

        for (int i = 0; i < heights.Length; i++)
        {
            if (stack.Count == 0)
                stack.Push(new Point(i, heights[i]));
            else
            {
                width = i;

                while (stack.Count != 0 && stack.Peek().Height > heights[i])
                {
                    Point p = stack.Pop();
                    width = p.Index;
                    int size = p.Height * (i - width);
                    if (answer < size)
                        answer = size;
                }
                stack.Push(new Point(width, heights[i]));
            }
        }

        foreach (Point p in stack)
        {
            int size = p.Height * (heights.Length - p.Index);
            if (answer < size)
                answer = size;
        }

        return answer;
    }
}

public class Point
{
    public int Index;
    public int Height;

    public Point(int index, int height)
    {
        Index = index;
        Height = height;
    }
}