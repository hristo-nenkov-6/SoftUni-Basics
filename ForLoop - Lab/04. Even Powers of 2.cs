using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i = i + 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}