using System;
using System.Text;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            for (int i = 0; i < 1000000; i++)
            {
                sb.Append("1, ");
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }
}
