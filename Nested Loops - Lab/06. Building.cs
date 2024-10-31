using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());

            for(int i = floor; i > 0; i--)
            {
               if(i == floor)
               {
                    for (int q = 0; q < room; q++)
                    {
                        Console.Write($"L{i}{q} ");
                    }
                    Console.WriteLine();
                }
                else if(i % 2 == 0)
                {
                    for (int q = 0; q < room; q++)
                    {
                        Console.Write($"O{i}{q} ");
                    }
                    Console.WriteLine();
                }
                else if (i % 2 == 1)
                {
                    for (int q = 0; q < room; q++)
                    {
                        Console.Write($"A{i}{q} ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}