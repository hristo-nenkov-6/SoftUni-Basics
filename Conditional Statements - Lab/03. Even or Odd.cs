using System;

namespace _10._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else { Console.WriteLine("odd"); }
        }
    }
}
