using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for(int rows = 1; rows <= n; rows++)
            {
                for (int col = 1; col <= rows; col++)
                {
                    if (current > n) { isBigger = true; break; }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger) break;
                Console.WriteLine();
            }
        }

    }
}