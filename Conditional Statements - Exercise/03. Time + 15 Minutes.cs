using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b >= 45)
            {
                a++;
                b = b - 45;
                if(a == 24) { a = 0; }
            }
            else { b = b + 15; }
            if (b < 10) { Console.WriteLine($"{a}:0{b}"); }
            else { Console.WriteLine($"{a}:{b}"); }
        }
    }
}
