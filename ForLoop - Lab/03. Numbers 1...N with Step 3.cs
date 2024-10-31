using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}