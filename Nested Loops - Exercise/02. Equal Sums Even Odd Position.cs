using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                int a1 = i / 100000;
                int a2 = (i / 10000) % 10;
                int a3 = (i / 1000) % 10;
                int a4 = (i / 100) % 10;
                int a5 = (i / 10) % 10;
                int a6 = i % 10;

                if((a1 + a3 + a5) == (a2 + a4 + a6))
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
}