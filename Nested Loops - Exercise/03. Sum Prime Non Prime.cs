using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    for(int g = 0; g <= n; g++)
                    {
                        if (i + j + g == n) br++;
                    }
                }
            }
            Console.WriteLine(br);
        }

    }
}