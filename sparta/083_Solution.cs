using System;

public class Solution083
{
    int answer = 0;
    public int solution(int k, int[,] dungeons)
    {

        bool[] isVisited = new bool[dungeons.GetLength(0)];

        dfs(k, 0, dungeons, isVisited);

        return answer;
    }

    public void dfs(int k, int cnt, int[,] dungeons, bool[] isVisited)
    {
        answer = Math.Max(answer, cnt);

        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (!isVisited[i] && k >= dungeons[i, 0])
            {
                isVisited[i] = true;
                dfs(k - dungeons[i, 1], cnt + 1, dungeons, isVisited);
                isVisited[i] = false;
            }
        }
    }
}