public class Solution011
{
    public bool solution(int x)
    {
        int harshad = 0;
        int i = x;

        while (i != 0)
        {
            harshad += i % 10;
            i /= 10;
        }

        if (x % harshad == 0)
            return true;

        return false;
    }
}