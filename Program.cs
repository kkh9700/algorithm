using System;
using System.Text;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "0 1 10", "0 2 3", "0 3 8", "1 0 10", "1 2 13", "1 4 14", "2 0 3", "2 1 13", "3 0 8", "3 4 9", "4 1 14", "4 3 9" };
            PrimMST prim = new PrimMST(5, input, 0);
        }
    }
}
