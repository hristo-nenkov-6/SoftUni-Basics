using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double br = 0;
            int a = int.Parse(Console.ReadLine());
            if(a <= 100) { br += 5; }
            else if (a > 1000) { br = br + a * 0.1; }
            else { br = br + a * 0.2; }

            if(a % 2 == 0) { br++; }
            else if(a % 10 == 5) { br += 2; }

            Console.WriteLine(br);
            Console.WriteLine(br + a);
        }
    }
}
