using System;
using System.Collections.Generic;

public class Solution062
{
    private Dictionary<string, int> dic;
    public string[] solution(string[] players, string[] callings)
    {
        dic = new Dictionary<string, int>();

        for (int i = 0; i < players.Length; i++)
        {
            dic.Add(players[i], i);
        }

        foreach (string s in callings)
        {
            overtake(dic[s], players);
        }

        return players;
    }

    public void overtake(int index, string[] players)
    {
        dic[players[index]] = index - 1;
        dic[players[index - 1]] = index;

        string tmp = players[index];
        players[index] = players[index - 1];
        players[index - 1] = tmp;
    }
}