public class Solution014
{
    public string solution(string[] seoul)
    {
        int length = seoul.Length;

        for (int i = 0; i < length; i++)
        {
            if (seoul[i].Equals("Kim"))
            {
                return "김서방은 " + i + "에 있다";
            }
        }



        return null;
    }
}