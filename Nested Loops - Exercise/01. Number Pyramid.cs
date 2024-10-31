using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i <= 23; i++)
            {
                for(int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
            }
        }

    }
}