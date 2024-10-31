using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int V = l * w * h;

            while(V > 0)
            {
                string num = Console.ReadLine();
                if(num != "Done")
                {
                    V -= int.Parse(num);
                }
                else { break; }
            }
            if(V > 0)
            {
                Console.WriteLine($"{V} Cubic meters left.");
            }
            else { Console.WriteLine($"No more free space! You need {Math.Abs(V)} Cubic meters more."); }
        }

    }
}