using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int mag = int.Parse(Console.ReadLine());
            int comb = 0;
            bool ismagic = false;
            
            for(int i = min; i <= max; i++)
            {
                for(int j = min; j <= max; j++)
                {
                    comb++;
                    if(i + j == mag)
                    {
                        Console.WriteLine($"Combination N:{comb} ({i} + {j} = {mag})");
                        ismagic = true;
                        break;
                    }
                }
                if (ismagic.Equals(true)) break;
            }
            if(ismagic.Equals(false))
            {
                Console.WriteLine($"{comb} combinations - neither equals {mag}");
            }
        }

    }
}