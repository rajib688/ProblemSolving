﻿using System;

namespace A._Bit__
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opernum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < opernum; i++)
            {
                String command = Console.ReadLine();
                if (command.Contains('-'))
                {
                    count--;
                }
                else if (command.Contains('+'))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        //public static int GCD(int A, int B)
        //{
        //    return B == 0 ? A : GCD(B, A % B);
        //}
    }
}
