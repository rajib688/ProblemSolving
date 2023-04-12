using System;

namespace ABoyorGirl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Code = Console.ReadLine();
            int l = Code.Length;
            int count = 0;
            char[] array = new char[l];
            for (int i = 0; i < Code.Length; i++)
            {
                array[i] = Code[i];
            }
            Array.Sort<char>(array);
            for (int j = 1; j < l; j++)
            {
                if (array[j] != array[j-1])
                {
                    count++;
                }
            }
            if ((count+1)%2==0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
}
