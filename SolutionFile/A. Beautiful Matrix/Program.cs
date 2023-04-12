using System;

namespace A._Beautiful_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                string s1 = Console.ReadLine();
                string[] s1values = s1.Split(' ');

                for (int j = 1; j <= 5; j++)
                {
                    int x = int.Parse(s1values[j - 1]);
                    if (x == 1)
                    {
                        Console.Write(Math.Abs(i - 3) + Math.Abs(j - 3));
                        Console.Read();
                    }
                }
            }
        }
    }
}
