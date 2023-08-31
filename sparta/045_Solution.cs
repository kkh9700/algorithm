using System;

public class Solution045
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        int index1 = 0, index2 = 0;

        for (int i = 0; i < goal.Length; i++)
        {
            if (index1 != cards1.Length && cards1[index1].Equals(goal[i]))
            {
                index1++;
            }
            else if (index2 != cards2.Length && cards2[index2].Equals(goal[i]))
            {
                index2++;
            }
            else
            {
                return "No";
            }
        }

        return "Yes";
    }
}