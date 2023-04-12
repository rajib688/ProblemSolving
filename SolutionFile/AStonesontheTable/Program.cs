using System;

namespace AStonesontheTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            for (int i = 0; i < a; i++)
            {
                if (s[i] == s[i+1])
                {
                    b++;
                }
            }
            Console.WriteLine(b);
        }
    }
}
