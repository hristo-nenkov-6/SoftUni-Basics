using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());

            int sum = t1 + t2 + t3;
            int minu = sum / 60;
            int sec = sum - minu * 60;

            if(sec < 10)
            {
                Console.WriteLine($"{minu}:0{sec}");
            }
            else { Console.WriteLine($"{minu}:{sec}"); }
        }
    }
}
