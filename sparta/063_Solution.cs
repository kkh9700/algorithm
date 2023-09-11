using System;

public class Solution063
{

    public int[] solution(string[] park, string[] routes)
    {
        int[] dx = { 0, 0, 1, -1 };
        int[] dy = { 1, -1, 0, 0 };
        int x = 0, y = 0, height = park.Length, width = park[0].Length;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (park[i][j] == 'S')
                {
                    x = i;
                    y = j;
                }
            }
        }

        foreach (string s in routes)
        {
            string[] split = s.Split(" ");

            int dir = -1;

            switch (split[0])
            {
                case "E":
                    dir = 0;
                    break;
                case "W":
                    dir = 1;
                    break;
                case "S":
                    dir = 2;
                    break;
                case "N":
                    dir = 3;
                    break;
            }

            int distance = Convert.ToInt32(split[1]);

            if (x + distance * dx[dir] >= height || x + distance * dx[dir] < 0 || y + distance * dy[dir] >= width || y + distance * dy[dir] < 0)
                continue;

            bool flag = true;

            if (dir == 0)
            {
                for (int i = y + 1; i <= y + distance; i++)
                {
                    if (park[x][i] == 'X')
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (dir == 1)
            {
                for (int i = y - 1; i >= y - distance; i--)
                {
                    if (park[x][i] == 'X')
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (dir == 2)
            {
                for (int i = x + 1; i <= x + distance; i++)
                {
                    if (park[i][y] == 'X')
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (dir == 3)
            {
                for (int i = x - 1; i >= x - distance; i--)
                {
                    if (park[i][y] == 'X')
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (flag)
            {
                x += (distance * dx[dir]);
                y += (distance * dy[dir]);
            }
        }

        return new int[] { x, y };
    }
}