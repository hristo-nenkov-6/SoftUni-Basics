using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = 0, max = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i == 0) {
                    max = a;
                    min = a;
                }
                else
                {
                    if (a > max)
                    {
                        max = a;
                    }
                    if(a < min)
                    {
                        min = a;
                    }

                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}