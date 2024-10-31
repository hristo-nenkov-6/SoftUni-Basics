using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    sum1 += a;
                }
                else sum2 += a;
            }
            if(sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}