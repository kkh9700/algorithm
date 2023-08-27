using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution007 solution = new Solution007();

            int[] array = solution.solution(10000000000L);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(array[i]);
                Console.WriteLine("---------");
            }
        }
    }
}
